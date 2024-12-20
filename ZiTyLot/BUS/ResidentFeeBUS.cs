﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiTyLot.DAO;
using ZiTyLot.DTOS;
using ZiTyLot.GUI.Utils;
using ZiTyLot.Helper;

namespace ZiTyLot.BUS
{
    internal class ResidentFeeBUS : IBUS<ResidentFee>
    {
        private readonly ResidentFeeDAO residentFeeDAO;
        private readonly VehicleTypeDAO vehicleTypeDAO;

        public ResidentFeeBUS()
        {
            this.residentFeeDAO = new ResidentFeeDAO();
            this.vehicleTypeDAO = new VehicleTypeDAO();
        }

        public void Add(ResidentFee item)
        {
            try
            {
                Validate(item);
                // Kiểm tra trùng lặp
                var existingFee = residentFeeDAO.GetAll(new List<FilterCondition>
                {
                    new FilterCondition("Vehicle_type_id", CompOp.Equals,item.Vehicle_type_id ),
                    new FilterCondition ("Month", CompOp.Equals, item.Month)
                });

                if (existingFee.Any())
                {
                    throw new ValidationInputException(
                        "Fee configuration already exists for this vehicle type and duration"
                    );
                }

                item.Created_at = DateTime.Now;
                residentFeeDAO.Add(item);
            }
            catch (ValidationInputException)
            {
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new BusinessException("Unable to add resident fee. Please try again later.");
            }
        }

        public void Delete(object id)
        {
            EnsureRecordExists(id);
            try
            {
                residentFeeDAO.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ResidentFee> GetAll(List<FilterCondition> filters = null)
        {
            try
            {
                return residentFeeDAO.GetAll(filters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Page<ResidentFee> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null)
        {
            try
            {
                return residentFeeDAO.GetAllPagination(pageable, filters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ResidentFee GetById(object id)
        {
            EnsureRecordExists(id);
            try
            {
                return residentFeeDAO.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(ResidentFee item)
        {
            EnsureRecordExists(item.Id);
            Validate(item);
            try
            {
                item.Updated_at = DateTime.Now;
                residentFeeDAO.Update(item);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //
        private void Validate(ResidentFee item)
        {
            if (!item.Vehicle_type_id.HasValue || item.Vehicle_type_id <= 0)
            {
                throw new ValidationInputException("Invalid vehicle type");
            }

            if (item.Month <= 0 || item.Month > 12)
            {
                throw new ValidationInputException("Month must be between 1 and 12");
            }

            if (item.Fee < 0)
            {
                throw new ValidationInputException("Fee cannot be negative");
            }

            if (item.Vehicle_type_id != null && vehicleTypeDAO.GetById(item.Vehicle_type_id) == null)
            {
                throw new ValidationInputException("Vehicle type does not exist");
            }
        }

        private void EnsureRecordExists(object id)
        {
            var existingItem = residentFeeDAO.GetById(id);
            if (existingItem == null)
            {
                throw new KeyNotFoundException($"Record with ID {id} not found.");
            }
        }

        // Population

        public ResidentFee PopulateVehicleType(ResidentFee item)
        {
            try
            {
                if (item.Vehicle_type_id.HasValue)
                {
                    VehicleType vehicleType = vehicleTypeDAO.GetById(item.Vehicle_type_id.Value);
                    item.Vehicle_type = vehicleType;
                    return item;
                }
                else
                {
                    throw new KeyNotFoundException($"VehicleTypeID is null, no record to search.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

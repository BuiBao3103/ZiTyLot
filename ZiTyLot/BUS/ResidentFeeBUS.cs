using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiTyLot.DAO;
using ZiTyLot.ENTITY;
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
            Validate(item);
            try
            {
                residentFeeDAO.Add(item);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
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
            //if (string.IsNullOrWhiteSpace(item.Name))
            //{
            //    throw new ArgumentException("Name cannot be null or empty.", nameof(item.Name));
            //}

            // Add other validation rules as needed
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

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
    internal class VisitorFeeBUS : IBUS<VisitorFee>
    {
        private readonly VisitorFeeDAO visitorFeeDAO;
        private readonly VehicleTypeDAO vehicleTypeDAO;

        public VisitorFeeBUS()
        {
            this.visitorFeeDAO = new VisitorFeeDAO();
            this.vehicleTypeDAO = new VehicleTypeDAO();
        }

        public void Add(VisitorFee item)
        {
            Validate(item);
            try
            {
                visitorFeeDAO.Add(item);
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
                visitorFeeDAO.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<VisitorFee> GetAll(List<FilterCondition> filters = null)
        {
            try
            {
                return visitorFeeDAO.GetAll(filters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Page<VisitorFee> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null)
        {
            try
            {
                return visitorFeeDAO.GetAllPagination(pageable, filters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public VisitorFee GetById(object id)
        {
            EnsureRecordExists(id);
            try
            {
                return visitorFeeDAO.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(VisitorFee item)
        {
            EnsureRecordExists(item.Id);
            Validate(item);
            try
            {
                visitorFeeDAO.Update(item);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //
        private void Validate(VisitorFee item)
        {
            //if (string.IsNullOrWhiteSpace(item.Name))
            //{
            //    throw new ArgumentException("Name cannot be null or empty.", nameof(item.Name));
            //}

            // Add other validation rules as needed
        }

        private void EnsureRecordExists(object id)
        {
            var existingItem = visitorFeeDAO.GetById(id);
            if (existingItem == null)
            {
                throw new KeyNotFoundException($"Record with ID {id} not found.");
            }
        }

        public VisitorFee PopulateVehicleType(VisitorFee item)
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

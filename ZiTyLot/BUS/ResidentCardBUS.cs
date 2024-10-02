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
    internal class ResidentCardBUS : IBUS<ResidentCard>
    {
        private readonly ResidentCardDAO residentCardDAO;
        private readonly CardDAO cardDAO;

        public ResidentCardBUS()
        {
            this.residentCardDAO = new ResidentCardDAO();
            this.cardDAO = new CardDAO();
        }

        public void Add(ResidentCard item)
        {
            Validate(item);
            try
            {
                residentCardDAO.Add(item);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(int id)
        {
            EnsureRecordExists(id);
            try
            {
                residentCardDAO.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ResidentCard> GetAll(List<FilterCondition> filters = null)
        {
            try
            {
                return residentCardDAO.GetAll(filters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Page<ResidentCard> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null)
        {
            try
            {
                return residentCardDAO.GetAllPagination(pageable, filters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ResidentCard GetById(int id)
        {
            EnsureRecordExists(id);
            try
            {
                return residentCardDAO.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(ResidentCard item)
        {
            EnsureRecordExists(item.Id);
            Validate(item);
            try
            {
                residentCardDAO.Update(item);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //
        private void Validate(ResidentCard item)
        {
            //if (string.IsNullOrWhiteSpace(item.Name))
            //{
            //    throw new ArgumentException("Name cannot be null or empty.", nameof(item.Name));
            //}

            // Add other validation rules as needed
        }

        private void EnsureRecordExists(int id)
        {
            var existingItem = residentCardDAO.GetById(id);
            if (existingItem == null)
            {
                throw new KeyNotFoundException($"Record with ID {id} not found.");
            }
        }

        public ResidentCard PopulateCard(ResidentCard item)
        {
            try
            {
                if (item.Card_id.HasValue)
                {
                    Card card = cardDAO.GetById(item.Card_id.Value);
                    item.Card = card;
                    return item;
                }
                else
                {
                    throw new KeyNotFoundException($"CardID is null, no record to search.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //
        public ResidentCard PopulateResident(ResidentCard item)
        {
            try
            {
                if (item.Resident_id.HasValue)
                {
                    Resident resident = null;
                    item.Resident = resident;
                    return item;
                }
                else
                {
                    throw new KeyNotFoundException($"ResidentID is null, no record to search.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiTyLot.DAO;
using ZiTyLot.DTOS;
using ZiTyLot.Helper;

namespace ZiTyLot.BUS
{
    internal class LostHistoryBUS : IBUS<LostHistory>
    {
        private readonly LostHistoryDAO lostHistoryDAO;
        private readonly CardDAO cardDAO;

        public LostHistoryBUS()
        {
            this.lostHistoryDAO = new LostHistoryDAO();
            this.cardDAO = new CardDAO();
        }

        public void Add(LostHistory item)
        {
            Validate(item);
            try
            {
                lostHistoryDAO.Add(item);
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
                lostHistoryDAO.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<LostHistory> GetAll(List<FilterCondition> filters = null)
        {
            try
            {
                return lostHistoryDAO.GetAll(filters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Page<LostHistory> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null)
        {
            try
            {
                return lostHistoryDAO.GetAllPagination(pageable, filters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public LostHistory GetById(object id)
        {
            EnsureRecordExists(id);
            try
            {
                return lostHistoryDAO.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(LostHistory item)
        {
            EnsureRecordExists(item.Id);
            Validate(item);
            try
            {
                lostHistoryDAO.Update(item);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //
        private void Validate(LostHistory item)
        {
            if (string.IsNullOrWhiteSpace(item.Owner_name))
            {
                throw new ArgumentException("Name cannot be null or empty.", nameof(item.Owner_name));
            }

            // Add other validation rules as needed
        }

        private void EnsureRecordExists(object id)
        {
            var existingItem = lostHistoryDAO.GetById(id);
            if (existingItem == null)
            {
                throw new KeyNotFoundException($"Record with ID {id} not found.");
            }
        }

        // Population

        public LostHistory PopulateCard(LostHistory item)
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
    }
}

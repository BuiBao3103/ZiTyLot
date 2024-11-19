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
    internal class ImageBUS : IBUS<Image>
    {
        private readonly ImageDAO imageDAO;
        private readonly SessionDAO sessionDAO;

        public ImageBUS()
        {
            this.imageDAO = new ImageDAO();
            this.sessionDAO = new SessionDAO();
        }

        public void Add(Image item)
        {
            Validate(item);
            try
            {
                item.Created_at = DateTime.Now;
                imageDAO.Add(item);
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
                imageDAO.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Image> GetAll(List<FilterCondition> filters = null)
        {
            try
            {
                return imageDAO.GetAll(filters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Page<Image> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null)
        {
            try
            {
                return imageDAO.GetAllPagination(pageable, filters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Image GetById(object id)
        {
            EnsureRecordExists(id);
            try
            {
                return imageDAO.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Image item)
        {
            EnsureRecordExists(item.Id);
            Validate(item);
            try
            {
                imageDAO.Update(item);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //
        private void Validate(Image item)
        {
            if (string.IsNullOrWhiteSpace(item.Url))
            {
                throw new ArgumentException("Name cannot be null or empty.", nameof(item.Url));
            }

            // Add other validation rules as needed
        }

        private void EnsureRecordExists(object id)
        {
            var existingItem = imageDAO.GetById(id);
            if (existingItem == null)
            {
                throw new KeyNotFoundException($"Record with ID {id} not found.");
            }
        }

        // Population

        public Image PopulateSession(Image item)
        {
            try
            {
                if (item.Session_id.HasValue)
                {
                    Session session = sessionDAO.GetById(item.Session_id.Value);
                    item.Session = session;
                    return item;
                }
                else
                {
                    throw new KeyNotFoundException($"SessionID is null, no record to search.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

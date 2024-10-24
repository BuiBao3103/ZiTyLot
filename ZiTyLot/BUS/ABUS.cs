﻿using System;
using System.Collections.Generic;
using ZiTyLot.DAO;
using ZiTyLot.Helper;
using ZiTyLot.ENTITY;
namespace ZiTyLot.BUS
{
    public class ABUS : IBUS<A>
    {
        private readonly ADAO aDao;
        private readonly BDAO bDao;

        public ABUS()
        {
            this.aDao = new ADAO();
            this.bDao = new BDAO();
        }

        public List<A> GetAll(List<FilterCondition> filters = null)
        {
            try
            {
                return aDao.GetAll(filters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // Hàm trả về đối tượng Page<MyDTO> với kết quả phân trang
        public Page<A> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null)
        {
            try
            {
                return aDao.GetAllPagination(pageable, filters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // Hàm lấy bản ghi theo ID
        public A GetById(object id)
        {
            EnsureRecordExists(id); // Kiểm tra sự tồn tại của bản ghi

            try
            {
                return aDao.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // Hàm thêm bản ghi mới
        public void Add(A item)
        {
            Validate(item); // Kiểm tra tính hợp lệ của dữ liệu

            try
            {
                aDao.Add(item);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // Hàm cập nhật bản ghi
        public void Update(A item)
        {
            EnsureRecordExists(item.Id); // Kiểm tra sự tồn tại của bản ghi

            Validate(item); // Kiểm tra tính hợp lệ của dữ liệu

            try
            {
                aDao.Update(item);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // Hàm xóa bản ghi theo ID
        public void Delete(object id)
        {
            EnsureRecordExists(id); // Kiểm tra sự tồn tại của bản ghi

            try
            {
                aDao.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // Hàm kiểm tra tính hợp lệ của bản ghi
        private void Validate(A item)
        {
            if (string.IsNullOrWhiteSpace(item.Name))
            {
                throw new ArgumentException("Name cannot be null or empty.", nameof(item.Name));
            }

            // Add other validation rules as needed
        }

        // Kiểm tra sự tồn tại của bản ghi
        private void EnsureRecordExists(object id)
        {
            var existingItem = aDao.GetById(id);
            if (existingItem == null)
            {
                throw new KeyNotFoundException($"Record with ID {id} not found.");
            }
        }
        public A PopulateBs(A a)
        {
            try
            {
                List<FilterCondition> filters = new List<FilterCondition>
                {
                    new FilterCondition("a_id", CompOp.Equals, a.Id)
                };
                List<B> bs = bDao.GetAll(filters);
                a.Bs = bs;
                return a;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}

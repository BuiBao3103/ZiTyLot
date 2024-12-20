﻿using System;
using System.Collections.Generic;
using ZiTyLot.Constants.Enum;
using ZiTyLot.DAO;
using ZiTyLot.DTOS;
using ZiTyLot.Helper;

namespace ZiTyLot.BUS
{
    public class BillBUS : IBUS<Bill>
    {
        private readonly BillDAO billDao = new BillDAO();
        private readonly ResidentDAO residentDAO= new ResidentDAO();
        private readonly AccountDAO accountDAO = new AccountDAO();
        private readonly IssueDAO issueDAO = new IssueDAO();
        private readonly SlotDAO slotDAO = new SlotDAO();

        public BillBUS()
        {
        }

        public Bill Create(Bill newBill, List<Issue> issues)
        {
            try
            {
                newBill.Created_at = DateTime.Now;
                newBill = billDao.AddAndGet(newBill);
                foreach (Issue issue in issues)
                {
                    issue.Created_at = DateTime.Now;
                    issue.Bill_id = newBill.Id;
                    issueDAO.Add(issue);
                }

                foreach (Issue issue in issues)
                {
                    if (issue.Slot_id != null)
                    {
                        Slot slot = slotDAO.GetById(issue.Slot_id);
                        slot.Status = SlotStatus.IN_USE;
                        slotDAO.Update(slot);
                    }
                }

                return newBill;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void Add(Bill item)
        {
            Validate(item); // Kiểm tra tính hợp lệ của dữ liệu

            try
            {
                item.Created_at = DateTime.Now;
                billDao.Add(item);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(object id)
        {
            // EnsureRecordExists(id); // Kiểm tra sự tồn tại của bản ghi

            try
            {
                billDao.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Bill> GetAll(List<FilterCondition> filters = null)
        {
            try
            {
                return billDao.GetAll(filters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Page<Bill> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null)
        {
            try
            {
               
                return billDao.GetAllPagination(pageable, filters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Bill GetById(object id)
        {
            try
            {
                return billDao.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching the data.", ex);
            }
        }

        public void Update(Bill item)
        {
            EnsureRecordExists(item.Id); // Kiểm tra sự tồn tại của bản ghi

            Validate(item); // Kiểm tra tính hợp lệ của dữ liệu

            try
            {
                billDao.Update(item);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void Validate(Bill item)
        {
            //if (string.IsNullOrWhiteSpace(item.Id))
            //{
            //    throw new ArgumentException("Name cannot be null or empty.", nameof(item.Id));
            //}

            // Add other validation rules as needed
        }

        // Kiểm tra sự tồn tại của bản ghi
        private void EnsureRecordExists(object id)
        {
            var existingItem = billDao.GetById(id);
            if (existingItem == null)
            {
                throw new KeyNotFoundException($"Record with ID {id} not found.");
            }
        }

        // Population

        public Bill PopulateResident(Bill item)
        {
            try
            {
                if (item.Resident_id.HasValue)
                {
                    Resident resident = residentDAO.GetById(item.Resident_id.Value);
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

        public Bill PopulateAccount(Bill item)
        {
            try
            {
                if (item.Account_id.HasValue)
                {
                    Account account = accountDAO.GetById(item.Account_id.Value);
                    item.Account = account;
                    return item;
                }
                else
                {
                    throw new KeyNotFoundException($"AccountID is null, no record to search.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Bill PopulateIssues(Bill item)
        {
            try
            {
                List<FilterCondition> filters = new List<FilterCondition>
                {
                    new FilterCondition("bill_id", CompOp.Equals, item.Id)
                };
                List<Issue> issues = issueDAO.GetAll(filters);
                item.Issues = issues;
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

﻿using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.Linq;
using ZiTyLot.Constants.Enum;
using ZiTyLot.DAO;
using ZiTyLot.DTOS;
using ZiTyLot.GUI.Utils;
using ZiTyLot.Helper;

namespace ZiTyLot.BUS
{
    public class ParkingLotBUS : IBUS<ParkingLot>
    {
        private readonly ParkingLotDAO parkingLotDAO;
        private readonly SlotDAO slotDAO;
        private readonly IssueDAO issueDAO;

        public ParkingLotBUS()
        {
            this.parkingLotDAO = new ParkingLotDAO();
            this.slotDAO = new SlotDAO();
            this.issueDAO = new IssueDAO();
        }
        public ParkingLot Create(ParkingLot newParkingLot)
        {
            //check id is exist 
            List<FilterCondition> filters = new List<FilterCondition>
            {
                new FilterCondition(nameof(ParkingLot.Id), CompOp.Equals, newParkingLot.Id)
            };
            var parkingLots = parkingLotDAO.GetAll(filters);
            if (parkingLots.Count != 0)
            {
                throw new ValidationInputException("Id is existed");
            }
            Validate(newParkingLot);
            newParkingLot.Created_at = DateTime.Now;
            parkingLotDAO.Add(newParkingLot);
            if (newParkingLot.Parking_lot_type == ParkingLotType.FOUR_WHEELER)
            {
                for (int i = 0; i < newParkingLot.Total_slot; i++)
                {
                    Slot slot = new Slot()
                    {
                        Parking_lot_id = newParkingLot.Id,
                        Status = SlotStatus.EMPTY,
                        Id = $"{newParkingLot.Id}-S{i + 1}",
                        Created_at = newParkingLot.Created_at,
                    };
                    slotDAO.Add(slot);
                }
            }
            return newParkingLot;
        }

        public void Add(ParkingLot item)
        {
            Validate(item); // Kiểm tra tính hợp lệ của dữ liệu

            try
            {
                item.Created_at = DateTime.Now;
                parkingLotDAO.Add(item);
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
                parkingLotDAO.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ParkingLot> GetAll(List<FilterCondition> filters = null)
        {
            try
            {
                return parkingLotDAO.GetAll(filters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Page<ParkingLot> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null)
        {
            try
            {
                return parkingLotDAO.GetAllPagination(pageable, filters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ParkingLot GetById(object id)
        {
            try
            {
                return parkingLotDAO.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching the data.", ex);
            }
        }

        public void Update(ParkingLot item)
        {
            EnsureRecordExists(item.Id); // Kiểm tra sự tồn tại của bản ghi

            Validate(item); // Kiểm tra tính hợp lệ của dữ liệu

            try
            {
                item.Updated_at = DateTime.Now;
                parkingLotDAO.Update(item);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void Validate(ParkingLot item)
        {
            if (string.IsNullOrWhiteSpace(item.Id))
            {
                throw new ArgumentException("Name cannot be null or empty.", nameof(item.Id));
            }
        }

        // Kiểm tra sự tồn tại của bản ghi
        private void EnsureRecordExists(string id)
        {
            var existingItem = parkingLotDAO.GetById(id);
            if (existingItem == null)
            {
                throw new KeyNotFoundException($"Record with ID {id} not found.");
            }
        }

        // Population

        public ParkingLot PopulateSlots(ParkingLot parkingLot)
        {
            try
            {
                List<FilterCondition> filters = new List<FilterCondition>
                {
                    new FilterCondition("parking_lot_id", CompOp.Equals, parkingLot.Id)
                };
                List<Slot> slots = slotDAO.GetAll(filters);
                parkingLot.Slots = slots;
                return parkingLot;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ParkingLot PopulateIssues(ParkingLot parkingLot)
        {
            try
            {
                List<FilterCondition> filters = new List<FilterCondition>
                {
                    new FilterCondition(nameof(ParkingLot.Deleted_at), CompOp.Equals, null),
                    new FilterCondition(nameof(Issue.Parking_lot_id), CompOp.Equals, parkingLot.Id)
                };
                List<Issue> issues = issueDAO.GetAll(filters);
                parkingLot.Issues = issues;
                return parkingLot;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

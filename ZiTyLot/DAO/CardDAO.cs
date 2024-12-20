﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiTyLot.Constants;
using ZiTyLot.DTOS;
using ZiTyLot.Helper;

namespace ZiTyLot.DAO
{
    internal class CardDAO : IDAO<Card>
    {
        private readonly FactoryDAO<Card> factoryDAO;

        public CardDAO()
        {
            factoryDAO = new FactoryDAO<Card>(DatabaseName.Card);
        }
        public void Add(Card item)
        {
            factoryDAO.Add(item);
        }

        public void Delete(object id)
        {
            factoryDAO.SoftDelete(id);
        }

        public List<Card> GetAll(List<FilterCondition> filters = null)
        {
            if (filters == null) filters = new List<FilterCondition>();
            filters.Add(new FilterCondition("deleted_at", CompOp.Equals, null));
            return factoryDAO.GetAll(filters);
        }

        public Page<Card> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null)
        {
            if (filters == null) filters = new List<FilterCondition>();
            filters.Add(new FilterCondition("deleted_at", CompOp.Equals, null));
            return factoryDAO.GetAllPagination(pageable, filters);
        }

        public Card GetById(object id)
        {
            return factoryDAO.GetById(id);
        }

        public void Update(Card item)
        {
            factoryDAO.Update(item);
        }

    }
}

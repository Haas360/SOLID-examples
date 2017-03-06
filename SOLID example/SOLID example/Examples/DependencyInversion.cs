using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLID_example.Examples
{
    public class DataContext
    {
        public List<Order> Orders { get; set; }
    }
    public class Order { }
    class BusinessLayer
    {
        private DataContext _dataContext = new DataContext();

        public void SubmitOrder()
        {
            _dataContext.Orders.Add(new Order());
        }
    }


    interface IDataContext
    {
        List<Order> Orders { get; set; }
    }
    class BusinessLayerv2
    {
        private IDataContext m_DataContext;

        public BusinessLayerv2(IDataContext context)
        {
            m_DataContext = context;
        }
        public void SubmitOrder()
        {
            m_DataContext.Orders.Add(new Order());
        }
    }
}

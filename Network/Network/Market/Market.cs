using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Market.Model
{
    // 아는 게 없으면 코딩도 못한다는 말이 실감이 되는구나.
    public class Market
    {
        [Key] public int Id { get; set; }
        public string User { get; set; }

        public List<Coupang> Coupang { get; set; }
        public List<Ebay> Ebay { get; set; }
        public List<IndependentMall> Mall { get; set; }
    }

    public class Coupang
    {
        [Key] public int Id { get; set; }
        public string UserId { get; set; }
        public string VendorId { get; set; }
        public string AccessKey { get; set; }
        public string SecreatKey { get; set; }

        public List<MCommodity> Commodities { get; set; }
        public List<Order> Orders { get; set; }
        public Market Market { get; set; }
    }

    public class Ebay
    {
        [Key] public int Id { get; set; }
        public string UserId { get; set; }
        public string VendorId { get; set; }
        public string AccessKey { get; set; }
        public string SecreatKey { get; set; }

        public List<MCommodity> Commodities { get; set; }
        public List<Order> Orders { get; set; }
        public Market Market { get; set; }
    }

    public class IndependentMall
    {
        [Key] public int Id { get; set; }
        public string UserId { get; set; }
        public string VendorId { get; set; }
        public string AccessCode { get; set; }

        public List<MCommodity> Commodities { get; set; }
        public List<Order> Orders { get; set; }
        public Market Market { get; set; }
    }

    public class MCommodity
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }        // �̸��� �ٽ� ������ �� �ֵ��� ���ָ� ���� �� ����.
        public int SCommodityId { get; set; }
        public int WCommodityId { get; set; }

        public List<Order> Orders { get; set; }
    }

    public class Order
    {
        [Key] public int Id { get; set; }
        public string OrderedAt { get; set; }
        public int Quantity {get; set;}

        public Coupang Coupang {get; set;}
        public Ebay Ebay {get; set;}
        public IndependentMall IndependentMall {get; set;}

        public Orderer Orderer { get; set; }        // ����ü 
        public MCommodity MCommodity { get; set; }
    }

    public struct Orderer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string safeNumber { get; set; }
        public string OrdererNumber { get; set; }
    }
}

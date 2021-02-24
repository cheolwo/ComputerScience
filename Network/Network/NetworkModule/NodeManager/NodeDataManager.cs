using NetworkModule.DataContext;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NetworkModule.Model;

namespace NetworkModule.NodeManager
{
    public class NodeDataManager
    {
        private readonly NetworkDataContext _networkDataContext;
        
        public List<Network> Networks { get; set; }

        public NodeDataManager(NetworkDataContext networkDataContext)
        {
            _networkDataContext = networkDataContext;
        }

        /// <summary>
        /// DefaultValue
        /// Network : 10
        /// Wan : 100
        /// Lan : 1000
        /// Node : 5000
        /// </summary>
        public void Init(int QuantityofNetwork)
        {
            Networks = _networkDataContext.Networks.ToList();
            if(Networks.Count.Equals(0)) { return; }     
        }

        /// <summary>
        /// 주소지정
        /// </summary>
        /// <param name="node"></param>
        /// <param name="RIR">지역</param>
        /// <param name="NIR">국가 또는 로컬</param>
        /// <param name="ISP">기관</param>
        /// <param name="EquipmentNumber">장비</param>
        public void SetAddress(Node node, string RIR, string NIR, string ISP, string EquipmentNumber)
        {
            
        }
        

        //public Dictionary<Country, int> RelativeDistance(Country country)
        //{
        //    switch (country)
        //    {
        //        case Country.Korea:
        //            break;
        //        case Country.China:
        //            break;
        //        case Country.Japan:
        //            break;
        //        case Country.America:
        //            break;
        //        case Country.Canada:
        //            break;
        //        case Country.France:
        //            break;
        //        case Country.Mongol:
        //            break;
        //        case Country.Rusia:
        //            break;
        //        case Country.Taiwan:
        //            break;
        //        case Country.India:
        //            break;
        //        case Country.England:
        //            break;
        //        default:
        //            break;
        //    }
        //}
        
    }
}

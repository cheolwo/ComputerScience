using System.ComponentModel.DataAnnotations;

namespace Coupang.Model.ofCategory.ofPost
{
    // 카테고리 추천
    public class Body
    {
        [Required] public string productNamae {get; set;}
        public string productDesc {get; set;}

        public string productName {get; set;}

        public string brand	 {get; set;}	
        
        public string attributes {get; set;} 	

        public string sellerSkuCode {get; set;}	 		
    }
}       

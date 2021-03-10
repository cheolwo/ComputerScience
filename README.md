# OurLogistics
WebAPI를 View단에서 이용하려면 React를 해야하는데...
그런데 MVC를 하다보면 자연스럽게 따라오는 게 REST API.
그렇기에 MVC를 먼저 하고 JSON을 다루는 식으로 방향을 잡는게 바람직.
VIEW가 없고 HttpResponse로 값을 주는 게 WebAPI의 방식
MVC는 View로 주고.

# OurLogistics, #Identity


# LogisticsCenter - MVC
1. 거래서버에 등록된 거래상품 입고인지 단계
1) 로그인 시 본인 Base 정보를 불러오는 단계
2) 본인 Base 정보를 통해 입고예정목록을 확인하는 단계
        Base.Code를 통해 TCommodity 목록을 확인하는 단계
    이미 WCommodity.TCommodityId 가 있다면 인지목록에 있는 것으로 나오도록 함.

    입고인지 과정은 총 3부분으로 나누어짐,.
    TCommodity의 CrossDockingCommodityofSeller
                 CrossDockingCommodityofBuyer
                 LogisticsAgencyCommodityofBuyer 
    를 확인해서 목적에 맞게 입고인지를 나눔.

3) Wcommodity에 등록.



Base로 들어오는 상품내역 조회 및 확인

1. 입고확인 단계
상품 바코드 검색을 통한 확인 단계.
바코드가 없는 경우 상품명 또는 이미지를 통한 확인. -- 입고대기품목리스트 출력기능의 필요.
입고 태그 등록 기능.

1. 검수 단계
처음 등록된 상품인 경우 가로, 세로, 높이 등의 정보등록 기능.
분할 바코드를 통한 상품 분할 기능.

1. 적재 단계
적재 바코드를 통한 적재 기능.
적재 태그의 종류에 따라 최대 적재 가능 품목 수 정함.

1. 피킹 단계
Market 서버로부터 들어온 주문과 Base에 있는 상품을 확인하는 단계
적재 위치를 확인하는 단계
피킹하는 단계

1. 포장 단계
피킹한 상품의 패킹정보를 통해 포장품을 선정하는 단계

1. 출고 단계
송장출력하여 포장상품에 부착하는 단계






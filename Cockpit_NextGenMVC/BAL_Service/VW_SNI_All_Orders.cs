//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BAL_Service
{
    using System;
    using System.Collections.Generic;
    
    public partial class VW_SNI_All_Orders
    {
        public double SALES_ORDERNO { get; set; }
        public string CUSTOMER_PO_NO { get; set; }
        public string SALES_ORG { get; set; }
        public string ORDER_OWNER { get; set; }
        public Nullable<int> ORDER_AGE { get; set; }
        public string SNI_AGING_BUCKET { get; set; }
        public Nullable<double> BACKLOG_AMT { get; set; }
        public string SOLD_TO_PARTY_NAME { get; set; }
        public string PAYMENT_TERMS { get; set; }
        public string DELIVERY_BLK_HDR_CD { get; set; }
        public string BILLING_BLOCK_CD { get; set; }
        public string NLHD_STATUS { get; set; }
        public Nullable<System.DateTime> COMMIT_DATE { get; set; }
        public System.DateTime TRIO_LOAD_DATE { get; set; }
        public Nullable<System.DateTime> CUSTOMER_REQ_GI_DATE { get; set; }
        public string INCOTERMS { get; set; }
        public string SNI_CLOSURE_STATUS { get; set; }
        public string DB_CLOSURE_STATUS { get; set; }
        public Nullable<System.DateTime> EXPECTED_RELEASE_DATE { get; set; }
        public string REASON_CODE { get; set; }
        public string LATEST_COMMENT { get; set; }
        public string DB_AGING_BUCKET { get; set; }
        public string PRIMARY_PRODUCT { get; set; }
        public string BACKLOG_STATUS { get; set; }
        public string REGION { get; set; }
        public string ZU_ACCOUNT_NAME { get; set; }
        public string ZU_COUNTRY { get; set; }
        public string DELTA_LOAD_DATE_BUCKET { get; set; }
        public string FE_FE_DESC { get; set; }
        public Nullable<int> SNI_Age { get; set; }
        public string Overall_Installation_Status { get; set; }
        public Nullable<System.DateTime> LATEST_COMMENT_DATE_TIME { get; set; }
        public string QUOTA_SF { get; set; }
    }
}

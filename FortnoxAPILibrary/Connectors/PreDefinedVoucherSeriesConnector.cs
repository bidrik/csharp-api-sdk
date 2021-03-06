using FortnoxAPILibrary.Entities;

// ReSharper disable UnusedMember.Global

namespace FortnoxAPILibrary.Connectors
{

    /// <remarks/>
    public class PreDefinedVoucherSeriesConnector : FinancialYearBasedEntityConnector<PreDefinedVoucherSeries, EntityCollection<PreDefinedVoucherSeriesSubset>, Sort.By.PreDefinedVoucherSeries?>
    {
		/// <remarks/>
		public PreDefinedVoucherSeriesConnector()
		{
			Resource = "predefinedvoucherseries";
		}
        
		/// <summary>
		/// Finds a pre defined voucher series by name
		/// </summary>
		/// <param name="name">The name of the voucher series to find</param>
		/// <returns>The found voucher series</returns>
		public PreDefinedVoucherSeries Get(PreDefinedVoucherSeriesName name)
		{
			return BaseGet(name.ToString());
		}

		/// <summary>
		/// Updates a pre defined voucher series
		/// </summary>
		/// <param name="preDefinedVoucherSeries">The voucher series to update</param>
		/// <returns></returns>
		public PreDefinedVoucherSeries Update(PreDefinedVoucherSeries preDefinedVoucherSeries)
		{
			return BaseUpdate(preDefinedVoucherSeries, preDefinedVoucherSeries.Name.ToString());
		}


		/// <summary>
		/// Gets a list of pre defined voucher series
		/// </summary>
		/// <returns></returns>
		public EntityCollection<PreDefinedVoucherSeriesSubset> Find()
		{
			return BaseFind();
		}
	}
}

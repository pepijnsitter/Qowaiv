using Qowaiv.Globalization;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Qowaiv.Financial
{
	internal partial struct CountryToCurrency
	{
		public static readonly ReadOnlyCollection<CountryToCurrency> All = new ReadOnlyCollection<CountryToCurrency>(new List<CountryToCurrency>()
		{
			new CountryToCurrency(Country.AD, Currency.ADP),
			new CountryToCurrency(Country.AE, Currency.AED),
			new CountryToCurrency(Country.AF, Currency.AFN),
			new CountryToCurrency(Country.AG, Currency.XCD),
			new CountryToCurrency(Country.AI, Currency.XCD),
			new CountryToCurrency(Country.AL, Currency.ALL),
			new CountryToCurrency(Country.AM, Currency.AMD),
			new CountryToCurrency(Country.ANHH, Currency.ANG),
			new CountryToCurrency(Country.AO, Currency.AOA),
			new CountryToCurrency(Country.AR, Currency.ARS),
			new CountryToCurrency(Country.AS, Currency.USD),
			new CountryToCurrency(Country.AT, Currency.ATS),
			new CountryToCurrency(Country.AU, Currency.AUD),
			new CountryToCurrency(Country.AW, Currency.AWG),
			new CountryToCurrency(Country.AX, Currency.FIM),
			new CountryToCurrency(Country.AZ, Currency.AZN),
			new CountryToCurrency(Country.BA, Currency.BAM),
			new CountryToCurrency(Country.BB, Currency.BBD),
			new CountryToCurrency(Country.BB, Currency.USD),
			new CountryToCurrency(Country.BD, Currency.BDT),
			new CountryToCurrency(Country.BE, Currency.BEF),
			new CountryToCurrency(Country.BF, Currency.XOF),
			new CountryToCurrency(Country.BG, Currency.BGN),
			new CountryToCurrency(Country.BH, Currency.BHD),
			new CountryToCurrency(Country.BI, Currency.BIF),
			new CountryToCurrency(Country.BJ, Currency.XOF),
			new CountryToCurrency(Country.BL, Currency.FRF),
			new CountryToCurrency(Country.BM, Currency.BMD),
			new CountryToCurrency(Country.BN, Currency.BND),
			new CountryToCurrency(Country.BO, Currency.BOB),
			new CountryToCurrency(Country.BQ, Currency.USD),
			new CountryToCurrency(Country.BQAQ, Currency.GBP),
			new CountryToCurrency(Country.BR, Currency.BRL),
			new CountryToCurrency(Country.BS, Currency.BSD),
			new CountryToCurrency(Country.BT, Currency.BTN),
			new CountryToCurrency(Country.BUMM, Currency.MMK),
			new CountryToCurrency(Country.BV, Currency.NOK),
			new CountryToCurrency(Country.BW, Currency.BWP),
			new CountryToCurrency(Country.BY, Currency.BYR),
			new CountryToCurrency(Country.BZ, Currency.BZD),
			new CountryToCurrency(Country.CA, Currency.CAD),
			new CountryToCurrency(Country.CC, Currency.AUD),
			new CountryToCurrency(Country.CD, Currency.CDF),
			new CountryToCurrency(Country.CF, Currency.XAF),
			new CountryToCurrency(Country.CG, Currency.XAF),
			new CountryToCurrency(Country.CH, Currency.CHF),
			new CountryToCurrency(Country.CI, Currency.XOF),
			new CountryToCurrency(Country.CK, Currency.NZD),
			new CountryToCurrency(Country.CL, Currency.CLP),
			new CountryToCurrency(Country.CM, Currency.XAF),
			new CountryToCurrency(Country.CN, Currency.CNY),
			new CountryToCurrency(Country.CO, Currency.COP),
			new CountryToCurrency(Country.CR, Currency.CRC),
			new CountryToCurrency(Country.CSHH, Currency.CSK),
			new CountryToCurrency(Country.CSXX, Currency.CSD),
			new CountryToCurrency(Country.CU, Currency.CUC),
			new CountryToCurrency(Country.CU, Currency.CUP),
			new CountryToCurrency(Country.CV, Currency.CVE),
			new CountryToCurrency(Country.CW, Currency.ANG),
			new CountryToCurrency(Country.CX, Currency.AUD),
			new CountryToCurrency(Country.CY, Currency.CYP),
			new CountryToCurrency(Country.CZ, Currency.CZK),
			new CountryToCurrency(Country.DDDE, Currency.DDM),
			new CountryToCurrency(Country.DE, Currency.DEM),
			new CountryToCurrency(Country.DJ, Currency.DJF),
			new CountryToCurrency(Country.DK, Currency.DKK),
			new CountryToCurrency(Country.DM, Currency.XCD),
			new CountryToCurrency(Country.DO, Currency.DOP),
			new CountryToCurrency(Country.DZ, Currency.DZD),
			new CountryToCurrency(Country.EC, Currency.ECS),
			new CountryToCurrency(Country.EE, Currency.EEK),
			new CountryToCurrency(Country.EG, Currency.EGP),
			new CountryToCurrency(Country.EH, Currency.MAD),
			new CountryToCurrency(Country.ER, Currency.ERN),
			new CountryToCurrency(Country.ES, Currency.ESP),
			new CountryToCurrency(Country.ET, Currency.ETB),
			new CountryToCurrency(Country.FI, Currency.FIM),
			new CountryToCurrency(Country.FJ, Currency.FJD),
			new CountryToCurrency(Country.FK, Currency.FKP),
			new CountryToCurrency(Country.FM, Currency.USD),
			new CountryToCurrency(Country.FO, Currency.DKK),
			new CountryToCurrency(Country.FR, Currency.FRF),
			new CountryToCurrency(Country.GA, Currency.XAF),
			new CountryToCurrency(Country.GB, Currency.GBP),
			new CountryToCurrency(Country.GD, Currency.XCD),
			new CountryToCurrency(Country.GE, Currency.GEL),
			new CountryToCurrency(Country.GF, Currency.FRF),
			new CountryToCurrency(Country.GG, Currency.GBP),
			new CountryToCurrency(Country.GH, Currency.GHS),
			new CountryToCurrency(Country.GI, Currency.GIP),
			new CountryToCurrency(Country.GL, Currency.DKK),
			new CountryToCurrency(Country.GM, Currency.GMD),
			new CountryToCurrency(Country.GN, Currency.GNF),
			new CountryToCurrency(Country.GP, Currency.FRF),
			new CountryToCurrency(Country.GQ, Currency.XAF),
			new CountryToCurrency(Country.GR, Currency.GRD),
			new CountryToCurrency(Country.GS, Currency.GBP),
			new CountryToCurrency(Country.GT, Currency.GTQ),
			new CountryToCurrency(Country.GU, Currency.USD),
			new CountryToCurrency(Country.GW, Currency.XOF),
			new CountryToCurrency(Country.GY, Currency.GYD),
			new CountryToCurrency(Country.HK, Currency.HKD),
			new CountryToCurrency(Country.HM, Currency.AUD),
			new CountryToCurrency(Country.HN, Currency.HNL),
			new CountryToCurrency(Country.HR, Currency.HRK),
			new CountryToCurrency(Country.HT, Currency.HTG),
			new CountryToCurrency(Country.HT, Currency.USD),
			new CountryToCurrency(Country.HU, Currency.HUF),
			new CountryToCurrency(Country.HVBF, Currency.XOF),
			new CountryToCurrency(Country.ID, Currency.IDR),
			new CountryToCurrency(Country.IE, Currency.IEP),
			new CountryToCurrency(Country.IL, Currency.ILS),
			new CountryToCurrency(Country.IM, Currency.GBP),
			new CountryToCurrency(Country.IN, Currency.INR),
			new CountryToCurrency(Country.IO, Currency.GBP),
			new CountryToCurrency(Country.IQ, Currency.IQD),
			new CountryToCurrency(Country.IR, Currency.IRR),
			new CountryToCurrency(Country.IS, Currency.ISK),
			new CountryToCurrency(Country.IT, Currency.ITL),
			new CountryToCurrency(Country.JE, Currency.GBP),
			new CountryToCurrency(Country.JM, Currency.JMD),
			new CountryToCurrency(Country.JO, Currency.JOD),
			new CountryToCurrency(Country.JP, Currency.JPY),
			new CountryToCurrency(Country.KE, Currency.KES),
			new CountryToCurrency(Country.KG, Currency.KGS),
			new CountryToCurrency(Country.KH, Currency.KHR),
			new CountryToCurrency(Country.KI, Currency.AUD),
			new CountryToCurrency(Country.KM, Currency.KMF),
			new CountryToCurrency(Country.KN, Currency.XCD),
			new CountryToCurrency(Country.KP, Currency.KPW),
			new CountryToCurrency(Country.KR, Currency.KRW),
			new CountryToCurrency(Country.KW, Currency.KWD),
			new CountryToCurrency(Country.KY, Currency.KYD),
			new CountryToCurrency(Country.KZ, Currency.KZT),
			new CountryToCurrency(Country.LA, Currency.LAK),
			new CountryToCurrency(Country.LB, Currency.LBP),
			new CountryToCurrency(Country.LC, Currency.XCD),
			new CountryToCurrency(Country.LI, Currency.CHF),
			new CountryToCurrency(Country.LK, Currency.LKR),
			new CountryToCurrency(Country.LR, Currency.LRD),
			new CountryToCurrency(Country.LS, Currency.LSL),
			new CountryToCurrency(Country.LT, Currency.LTL),
			new CountryToCurrency(Country.LU, Currency.LUF),
			new CountryToCurrency(Country.LV, Currency.LVL),
			new CountryToCurrency(Country.LY, Currency.LYD),
			new CountryToCurrency(Country.MA, Currency.MAD),
			new CountryToCurrency(Country.MC, Currency.MCF),
			new CountryToCurrency(Country.MD, Currency.MDL),
			new CountryToCurrency(Country.MF, Currency.EUR),
			new CountryToCurrency(Country.MG, Currency.MGA),
			new CountryToCurrency(Country.MH, Currency.USD),
			new CountryToCurrency(Country.MK, Currency.MKD),
			new CountryToCurrency(Country.ML, Currency.XOF),
			new CountryToCurrency(Country.MM, Currency.MMK),
			new CountryToCurrency(Country.MN, Currency.MNT),
			new CountryToCurrency(Country.MO, Currency.HKD),
			new CountryToCurrency(Country.MO, Currency.MOP),
			new CountryToCurrency(Country.MP, Currency.USD),
			new CountryToCurrency(Country.MQ, Currency.FRF),
			new CountryToCurrency(Country.MR, Currency.MRO),
			new CountryToCurrency(Country.MS, Currency.XCD),
			new CountryToCurrency(Country.MT, Currency.MTL),
			new CountryToCurrency(Country.MU, Currency.MUR),
			new CountryToCurrency(Country.MV, Currency.MVR),
			new CountryToCurrency(Country.MW, Currency.MWK),
			new CountryToCurrency(Country.MX, Currency.MXN),
			new CountryToCurrency(Country.MX, Currency.MXV),
			new CountryToCurrency(Country.MY, Currency.MYR),
			new CountryToCurrency(Country.MZ, Currency.MZN),
			new CountryToCurrency(Country.NA, Currency.NAD),
			new CountryToCurrency(Country.NC, Currency.XPF),
			new CountryToCurrency(Country.NE, Currency.XOF),
			new CountryToCurrency(Country.NF, Currency.AUD),
			new CountryToCurrency(Country.NG, Currency.NGN),
			new CountryToCurrency(Country.NI, Currency.NIO),
			new CountryToCurrency(Country.NL, Currency.NLG),
			new CountryToCurrency(Country.NL, Currency.NLG),
			new CountryToCurrency(Country.NO, Currency.NOK),
			new CountryToCurrency(Country.NP, Currency.NPR),
			new CountryToCurrency(Country.NR, Currency.AUD),
			new CountryToCurrency(Country.NU, Currency.NZD),
			new CountryToCurrency(Country.NZ, Currency.NZD),
			new CountryToCurrency(Country.OM, Currency.OMR),
			new CountryToCurrency(Country.PA, Currency.PAB),
			new CountryToCurrency(Country.PA, Currency.USD),
			new CountryToCurrency(Country.PE, Currency.PEN),
			new CountryToCurrency(Country.PF, Currency.XPF),
			new CountryToCurrency(Country.PG, Currency.PGK),
			new CountryToCurrency(Country.PH, Currency.PHP),
			new CountryToCurrency(Country.PK, Currency.PKR),
			new CountryToCurrency(Country.PL, Currency.PLN),
			new CountryToCurrency(Country.PM, Currency.FRF),
			new CountryToCurrency(Country.PN, Currency.NZD),
			new CountryToCurrency(Country.PR, Currency.USD),
			new CountryToCurrency(Country.PS, Currency.ILS),
			new CountryToCurrency(Country.PT, Currency.PTE),
			new CountryToCurrency(Country.PW, Currency.USD),
			new CountryToCurrency(Country.PY, Currency.PYG),
			new CountryToCurrency(Country.QA, Currency.QAR),
			new CountryToCurrency(Country.RE, Currency.FRF),
			new CountryToCurrency(Country.RO, Currency.RON),
			new CountryToCurrency(Country.RS, Currency.RSD),
			new CountryToCurrency(Country.RU, Currency.RUB),
			new CountryToCurrency(Country.RW, Currency.RWF),
			new CountryToCurrency(Country.SA, Currency.SAR),
			new CountryToCurrency(Country.SB, Currency.SBD),
			new CountryToCurrency(Country.SC, Currency.SCR),
			new CountryToCurrency(Country.SD, Currency.SDG),
			new CountryToCurrency(Country.SE, Currency.SEK),
			new CountryToCurrency(Country.SG, Currency.SGD),
			new CountryToCurrency(Country.SH, Currency.GBP),
			new CountryToCurrency(Country.SH, Currency.SHP),
			new CountryToCurrency(Country.SI, Currency.SIT),
			new CountryToCurrency(Country.SJ, Currency.NOK),
			new CountryToCurrency(Country.SK, Currency.SKK),
			new CountryToCurrency(Country.SL, Currency.SLL),
			new CountryToCurrency(Country.SM, Currency.SML),
			new CountryToCurrency(Country.SN, Currency.XOF),
			new CountryToCurrency(Country.SO, Currency.SOS),
			new CountryToCurrency(Country.SR, Currency.SRD),
			new CountryToCurrency(Country.SS, Currency.SSP),
			new CountryToCurrency(Country.ST, Currency.STD),
			new CountryToCurrency(Country.SUHH, Currency.SUR),
			new CountryToCurrency(Country.SV, Currency.USD),
			new CountryToCurrency(Country.SX, Currency.ANG),
			new CountryToCurrency(Country.SY, Currency.SYP),
			new CountryToCurrency(Country.SZ, Currency.SZL),
			new CountryToCurrency(Country.TC, Currency.USD),
			new CountryToCurrency(Country.TD, Currency.XAF),
			new CountryToCurrency(Country.TF, Currency.FRF),
			new CountryToCurrency(Country.TG, Currency.XOF),
			new CountryToCurrency(Country.TH, Currency.THB),
			new CountryToCurrency(Country.TJ, Currency.TJS),
			new CountryToCurrency(Country.TK, Currency.NZD),
			new CountryToCurrency(Country.TL, Currency.USD),
			new CountryToCurrency(Country.TM, Currency.TMT),
			new CountryToCurrency(Country.TN, Currency.TND),
			new CountryToCurrency(Country.TO, Currency.TOP),
			new CountryToCurrency(Country.TR, Currency.TRY),
			new CountryToCurrency(Country.TT, Currency.TTD),
			new CountryToCurrency(Country.TV, Currency.AUD),
			new CountryToCurrency(Country.TW, Currency.TWD),
			new CountryToCurrency(Country.TZ, Currency.TZS),
			new CountryToCurrency(Country.UA, Currency.UAH),
			new CountryToCurrency(Country.UG, Currency.UGX),
			new CountryToCurrency(Country.UM, Currency.USD),
			new CountryToCurrency(Country.US, Currency.USD),
			new CountryToCurrency(Country.UY, Currency.UYU),
			new CountryToCurrency(Country.UZ, Currency.UZS),
			new CountryToCurrency(Country.VA, Currency.VAL),
			new CountryToCurrency(Country.VC, Currency.XCD),
			new CountryToCurrency(Country.VE, Currency.VEF),
			new CountryToCurrency(Country.VG, Currency.USD),
			new CountryToCurrency(Country.VI, Currency.USD),
			new CountryToCurrency(Country.VN, Currency.VND),
			new CountryToCurrency(Country.VU, Currency.VUV),
			new CountryToCurrency(Country.WF, Currency.XPF),
			new CountryToCurrency(Country.WS, Currency.WST),
			new CountryToCurrency(Country.YE, Currency.YER),
			new CountryToCurrency(Country.YT, Currency.FRF),
			new CountryToCurrency(Country.ZA, Currency.ZAR),
			new CountryToCurrency(Country.ZM, Currency.ZMW),
			new CountryToCurrency(Country.ZRCD, Currency.ZRZ),
			new CountryToCurrency(Country.YUCS, Currency.YUD, new Date(1961, 12, 31)),
			new CountryToCurrency(Country.ZW, Currency.ZWC, new Date(1966, 02, 16)),
			new CountryToCurrency(Country.ZW, Currency.ZWD, new Date(1976, 04, 17)),
			new CountryToCurrency(Country.YUCS, Currency.YUN, new Date(1985, 12, 31)),
			new CountryToCurrency(Country.YUCS, Currency.YUR, new Date(1988, 06, 30)),
			new CountryToCurrency(Country.YUCS, Currency.YOU, new Date(1989, 09, 30)),
			new CountryToCurrency(Country.YUCS, Currency.YUG, new Date(1989, 12, 31)),
			new CountryToCurrency(Country.YUCS, Currency.YUM, new Date(1990, 01, 23)),
			new CountryToCurrency(Country.DDDE, Currency.DEM, new Date(1990, 07, 01)),
			new CountryToCurrency(Country.ZRCD, Currency.ZRN, new Date(1993, 01, 01)),
			new CountryToCurrency(Country.EC, Currency.USD, new Date(2000, 03, 13)),
			new CountryToCurrency(Country.AD, Currency.EUR, new Date(2002, 01, 01)),
			new CountryToCurrency(Country.AT, Currency.EUR, new Date(2002, 01, 01)),
			new CountryToCurrency(Country.AX, Currency.EUR, new Date(2002, 01, 01)),
			new CountryToCurrency(Country.BE, Currency.EUR, new Date(2002, 01, 01)),
			new CountryToCurrency(Country.BL, Currency.EUR, new Date(2002, 01, 01)),
			new CountryToCurrency(Country.DE, Currency.EUR, new Date(2002, 01, 01)),
			new CountryToCurrency(Country.ES, Currency.EUR, new Date(2002, 01, 01)),
			new CountryToCurrency(Country.FI, Currency.EUR, new Date(2002, 01, 01)),
			new CountryToCurrency(Country.FR, Currency.EUR, new Date(2002, 01, 01)),
			new CountryToCurrency(Country.GF, Currency.EUR, new Date(2002, 01, 01)),
			new CountryToCurrency(Country.GP, Currency.EUR, new Date(2002, 01, 01)),
			new CountryToCurrency(Country.GR, Currency.EUR, new Date(2002, 01, 01)),
			new CountryToCurrency(Country.IE, Currency.EUR, new Date(2002, 01, 01)),
			new CountryToCurrency(Country.IT, Currency.EUR, new Date(2002, 01, 01)),
			new CountryToCurrency(Country.LU, Currency.EUR, new Date(2002, 01, 01)),
			new CountryToCurrency(Country.MC, Currency.EUR, new Date(2002, 01, 01)),
			new CountryToCurrency(Country.ME, Currency.EUR, new Date(2002, 01, 01)),
			new CountryToCurrency(Country.MQ, Currency.EUR, new Date(2002, 01, 01)),
			new CountryToCurrency(Country.NL, Currency.EUR, new Date(2002, 01, 01)),
			new CountryToCurrency(Country.PM, Currency.EUR, new Date(2002, 01, 01)),
			new CountryToCurrency(Country.PT, Currency.EUR, new Date(2002, 01, 01)),
			new CountryToCurrency(Country.RE, Currency.EUR, new Date(2002, 01, 01)),
			new CountryToCurrency(Country.SM, Currency.EUR, new Date(2002, 01, 01)),
			new CountryToCurrency(Country.TF, Currency.EUR, new Date(2002, 01, 01)),
			new CountryToCurrency(Country.VA, Currency.EUR, new Date(2002, 01, 01)),
			new CountryToCurrency(Country.YT, Currency.EUR, new Date(2002, 01, 01)),
			new CountryToCurrency(Country.ZW, Currency.ZWN, new Date(2002, 07, 31)),
			new CountryToCurrency(Country.ZW, Currency.ZWR, new Date(2004, 07, 31)),
			new CountryToCurrency(Country.ZW, Currency.ZWL, new Date(2005, 02, 02)),
			new CountryToCurrency(Country.SI, Currency.EUR, new Date(2007, 01, 01)),
			new CountryToCurrency(Country.CY, Currency.EUR, new Date(2008, 01, 01)),
			new CountryToCurrency(Country.MT, Currency.EUR, new Date(2008, 01, 01)),
			new CountryToCurrency(Country.SK, Currency.EUR, new Date(2009, 01, 01)),
			new CountryToCurrency(Country.ZW, Currency.USD, new Date(2009, 04, 12)),
			new CountryToCurrency(Country.EE, Currency.EUR, new Date(2011, 01, 01)),
			new CountryToCurrency(Country.LV, Currency.EUR, new Date(2014, 01, 01)),
			new CountryToCurrency(Country.LT, Currency.EUR, new Date(2015, 01, 01)),
		});
	}
}

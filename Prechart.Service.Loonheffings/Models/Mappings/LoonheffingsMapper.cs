using AutoMapper;
using Prechart.Service.Core.Extensions;
using Prechart.Service.Globals.Models.Xsd.Loonheffings;

namespace Prechart.Service.Loonheffings.Models.Mappings;

public class LoonheffingsMapper : Profile
{
    public LoonheffingsMapper()
    {
        CreateMap<InkomstenperiodeInitieelType, Globals.Models.Loonheffings.Xsd.Xsd2022.InkomstenperiodeInitieelType>()
            .ForMember(d => d.DatAanv, o => o.MapFrom(s => s.DatAanv))
            .ForMember(d => d.SrtIV, o => o.MapFrom(s => s.SrtIv))
            .ForMember(d => d.CdAard, o => o.MapFrom(s => s.CdAard))
            .ForMember(d => d.CdAardSpecified, o => o.MapFrom(s => s.CdAardSpecified))
            .ForMember(d => d.CdInvlVpl, o => o.MapFrom(s => s.CdInvlVpl))
            .ForMember(d => d.FsIndFZ, o => o.MapFrom(s => s.FsIndFz))
            .ForMember(d => d.FsIndFZSpecified, o => o.MapFrom(s => s.FsIndFzSpecified))
            .ForMember(d => d.CAO, o => o.MapFrom(s => s.Cao))
            .ForMember(d => d.CdCaoInl, o => o.MapFrom(s => s.CdCaoInl))
            .ForMember(d => d.IndArbovOnbepTd, o => o.MapFrom(s => s.IndArbovOnbepTd))
            .ForMember(d => d.IndArbovOnbepTdSpecified, o => o.MapFrom(s => s.IndArbovOnbepTdSpecified))
            .ForMember(d => d.IndSchriftArbov, o => o.MapFrom(s => s.IndSchriftArbov))
            .ForMember(d => d.IndSchriftArbovSpecified, o => o.MapFrom(s => s.IndSchriftArbovSpecified))
            .ForMember(d => d.IndOprov, o => o.MapFrom(s => s.IndOprov))
            .ForMember(d => d.IndOprovSpecified, o => o.MapFrom(s => s.IndOprovSpecified))
            .ForMember(d => d.IndJrurennrm, o => o.MapFrom(s => s.IndJrurennrm))
            .ForMember(d => d.IndJrurennrmSpecified, o => o.MapFrom(s => s.IndJrurennrmSpecified))
            .ForMember(d => d.IndPubAanOnbepTd, o => o.MapFrom(s => s.IndPubAanOnbepTd))
            .ForMember(d => d.IndPubAanOnbepTdSpecified, o => o.MapFrom(s => s.IndPubAanOnbepTdSpecified))
            .ForMember(d => d.IndAvrLkvOudrWn, o => o.MapFrom(s => s.IndAvrLkvOudrWn))
            .ForMember(d => d.IndAvrLkvOudrWnSpecified, o => o.MapFrom(s => s.IndAvrLkvOudrWnSpecified))
            .ForMember(d => d.IndAvrLkvAgWn, o => o.MapFrom(s => s.IndAvrLkvAgWn))
            .ForMember(d => d.IndAvrLkvAgWnSpecified, o => o.MapFrom(s => s.IndAvrLkvAgWnSpecified))
            .ForMember(d => d.IndAvrLkvDgBafSb, o => o.MapFrom(s => s.IndAvrLkvDgBafSb))
            .ForMember(d => d.IndAvrLkvDgBafSbSpecified, o => o.MapFrom(s => s.IndAvrLkvDgBafSbSpecified))
            .ForMember(d => d.IndAvrLkvHpAgWn, o => o.MapFrom(s => s.IndAvrLkvHpAgWn))
            .ForMember(d => d.IndAvrLkvHpAgWnSpecified, o => o.MapFrom(s => s.IndAvrLkvHpAgWnSpecified))
            .ForMember(d => d.IndLhKort, o => o.MapFrom(s => s.IndLhKort))
            .ForMember(d => d.CdRdnGnBijt, o => o.MapFrom(s => s.CdRdnGnBijt))
            .ForMember(d => d.CdRdnGnBijtSpecified, o => o.MapFrom(s => s.CdRdnGnBijtSpecified))
            .ForMember(d => d.LbTab, o => o.MapFrom(s => s.LbTab))
            .ForMember(d => d.IndWAO, o => o.MapFrom(s => s.IndWao))
            .ForMember(d => d.IndWW, o => o.MapFrom(s => s.IndWw))
            .ForMember(d => d.IndZW, o => o.MapFrom(s => s.IndZw))
            .ForMember(d => d.IndWgldOudRegl, o => o.MapFrom(s => s.IndWgldOudRegl))
            .ForMember(d => d.IndWgldOudReglSpecified, o => o.MapFrom(s => s.IndWgldOudReglSpecified))
            .ForMember(d => d.CdZvw, o => o.MapFrom(s => s.CdZvw))
            .ForMember(d => d.IndVakBn, o => o.MapFrom(s => s.IndVakBn))
            .ForMember(d => d.IndVakBnSpecified, o => o.MapFrom(s => s.IndVakBnSpecified))
            .ForMember(d => d.IndSA71, o => o.MapFrom(s => s.IndSa71))
            .ForMember(d => d.IndSA71Specified, o => o.MapFrom(s => s.IndSa71Specified))
            .ForMember(d => d.IndSA72, o => o.MapFrom(s => s.IndSa72))
            .ForMember(d => d.IndSA72Specified, o => o.MapFrom(s => s.IndSa72Specified))
            .ForMember(d => d.IndSA03, o => o.MapFrom(s => s.IndSa03))
            .ForMember(d => d.IndSA03Specified, o => o.MapFrom(s => s.IndSa03Specified))
            .ForMember(d => d.CdIncInkVerm, o => o.MapFrom(s => s.CdIncInkVerm))
            .ForMember(d => d.CdIncInkVermSpecified, o => o.MapFrom(s => s.CdIncInkVermSpecified))
            .ReverseMap();

        CreateMap<InkomstenverhoudingInitieelTypeNatuurlijkPersoon,
                Globals.Models.Loonheffings.Xsd.Xsd2022.InkomstenverhoudingInitieelTypeNatuurlijkPersoon>()
            .ForMember(d => d.SofiNr, o => o.MapFrom(s => s.SofiNr))
            .ForMember(d => d.Voorl, o => o.MapFrom(s => s.Voorl))
            .ForMember(d => d.Voorv, o => o.MapFrom(s => s.Voorv))
            .ForMember(d => d.SignNm, o => o.MapFrom(s => s.SignNm))
            .ForMember(d => d.Gebdat, o => o.MapFrom(s => s.Gebdat))
            .ForMember(d => d.GebdatSpecified, o => o.MapFrom(s => s.GebdatSpecified))
            .ForMember(d => d.Nat, o => o.MapFrom(s => s.Nat))
            .ForMember(d => d.Gesl, o => o.MapFrom(s => s.Gesl))
            .ForMember(d => d.GeslSpecified, o => o.MapFrom(s => s.GeslSpecified))
            .ReverseMap();

        CreateMap<AdresBinnenlandType, Globals.Models.Loonheffings.Xsd.Xsd2022.AdresBinnenlandType>()
            .ForMember(d => d.Str, o => o.MapFrom(s => s.Str))
            .ForMember(d => d.HuisNr, o => o.MapFrom(s => s.HuisNr))
            .ForMember(d => d.HuisNrToev, o => o.MapFrom(s => s.HuisNrToev))
            .ForMember(d => d.LocOms, o => o.MapFrom(s => s.LocOms))
            .ForMember(d => d.Pc, o => o.MapFrom(s => s.Pc))
            .ForMember(d => d.Woonpl, o => o.MapFrom(s => s.Woonpl))
            .ReverseMap();

        CreateMap<AdresBuitenlandType, Globals.Models.Loonheffings.Xsd.Xsd2022.AdresBuitenlandType>()
            .ForMember(d => d.Str, o => o.MapFrom(s => s.Str))
            .ForMember(d => d.HuisNr, o => o.MapFrom(s => s.HuisNr))
            .ForMember(d => d.LandCd, o => o.MapFrom(s => s.LandCd))
            .ForMember(d => d.LocOms, o => o.MapFrom(s => s.LocOms))
            .ForMember(d => d.Pc, o => o.MapFrom(s => s.Pc))
            .ForMember(d => d.Woonpl, o => o.MapFrom(s => s.Woonpl))
            .ForMember(d => d.Reg, o => o.MapFrom(s => s.Reg))
            .ReverseMap();

        CreateMap<WerknemersgegevensType, Globals.Models.Loonheffings.Xsd.Xsd2022.WerknemersgegevensType>()
            .ForMember(d => d.LnLbPh, o => o.MapFrom(s => s.LnLbPh))
            .ForMember(d => d.LnSV, o => o.MapFrom(s => s.LnSv))
            .ForMember(d => d.PrlnAofAnwLg, o => o.MapFrom(s => s.PrlnAofAnwLg))
            .ForMember(d => d.PrlnAofAnwHg, o => o.MapFrom(s => s.PrlnAofAnwHg))
            .ForMember(d => d.PrlnAofAnwUit, o => o.MapFrom(s => s.PrlnAofAnwUit))
            .ForMember(d => d.PrlnAwfAnwLg, o => o.MapFrom(s => s.PrlnAwfAnwLg))
            .ForMember(d => d.PrlnAwfAnwHg, o => o.MapFrom(s => s.PrlnAwfAnwHg))
            .ForMember(d => d.PrlnAwfAnwHz, o => o.MapFrom(s => s.PrlnAwfAnwHz))
            .ForMember(d => d.PrLnUfo, o => o.MapFrom(s => s.PrLnUfo))
            .ForMember(d => d.LnTabBB, o => o.MapFrom(s => s.LnTabBb))
            .ForMember(d => d.VakBsl, o => o.MapFrom(s => s.VakBsl))
            .ForMember(d => d.OpgRchtVakBsl, o => o.MapFrom(s => s.OpgRchtVakBsl))
            .ForMember(d => d.OpnAvwb, o => o.MapFrom(s => s.OpnAvwb))
            .ForMember(d => d.OpbAvwb, o => o.MapFrom(s => s.OpbAvwb))
            .ForMember(d => d.LnInGld, o => o.MapFrom(s => s.LnInGld))
            .ForMember(d => d.WrdLn, o => o.MapFrom(s => s.WrdLn))
            .ForMember(d => d.LnOwrk, o => o.MapFrom(s => s.LnOwrk))
            .ForMember(d => d.VerstrAanv, o => o.MapFrom(s => s.VerstrAanv))
            .ForMember(d => d.IngLbPh, o => o.MapFrom(s => s.IngLbPh))
            .ForMember(d => d.PrAofLg, o => o.MapFrom(s => s.PrAofLg))
            .ForMember(d => d.PrAofHg, o => o.MapFrom(s => s.PrAofHg))
            .ForMember(d => d.PrAofUit, o => o.MapFrom(s => s.PrAofUit))
            .ForMember(d => d.OpslWko, o => o.MapFrom(s => s.OpslWko))
            .ForMember(d => d.PrGediffWhk, o => o.MapFrom(s => s.PrGediffWhk))
            .ForMember(d => d.PrAwfLg, o => o.MapFrom(s => s.PrAwfLg))
            .ForMember(d => d.PrAwfHg, o => o.MapFrom(s => s.PrAwfHg))
            .ForMember(d => d.PrAwfHz, o => o.MapFrom(s => s.PrAwfHz))
            .ForMember(d => d.PrUFO, o => o.MapFrom(s => s.PrUfo))
            .ForMember(d => d.BijdrZvw, o => o.MapFrom(s => s.BijdrZvw))
            .ForMember(d => d.WghZvw, o => o.MapFrom(s => s.WghZvw))
            .ForMember(d => d.WrdPrGebrAut, o => o.MapFrom(s => s.WrdPrGebrAut))
            .ForMember(d => d.WrknBijdrAut, o => o.MapFrom(s => s.WrknBijdrAut))
            .ForMember(d => d.Reisk, o => o.MapFrom(s => s.Reisk))
            .ForMember(d => d.VerrArbKrt, o => o.MapFrom(s => s.VerrArbKrt))
            .ForMember(d => d.AantVerlU, o => o.MapFrom(s => s.AantVerlU))
            .ForMember(d => d.Ctrctln, o => o.MapFrom(s => s.Ctrctln))
            .ForMember(d => d.CtrctlnSpecified, o => o.MapFrom(s => s.CtrctlnSpecified))
            .ForMember(d => d.AantCtrcturenPWk, o => o.MapFrom(s => s.AantCtrcturenPWk))
            .ForMember(d => d.AantCtrcturenPWkSpecified, o => o.MapFrom(s => s.AantCtrcturenPWkSpecified))
            .ForMember(d => d.BedrRntKstvPersl, o => o.MapFrom(s => s.BedrRntKstvPersl))
            .ForMember(d => d.BedrAlInWWB, o => o.MapFrom(s => s.BedrAlInWwb))
            .ForMember(d => d.BedrAlInWWBSpecified, o => o.MapFrom(s => s.BedrAlInWwbSpecified))
            .ForMember(d => d.BedrRchtAl, o => o.MapFrom(s => s.BedrRchtAl))
            .ForMember(d => d.BedrRchtAlSpecified, o => o.MapFrom(s => s.BedrRchtAlSpecified))
            .ReverseMap();

        CreateMap<InkomstenperiodeInitieelType, Globals.Models.Loonheffings.Xsd.Xsd2022.InkomstenperiodeInitieelType>()
            .ForMember(d => d.DatAanv, o => o.MapFrom(s => s.DatAanv))
            .ForMember(d => d.SrtIV, o => o.MapFrom(s => s.SrtIv))
            .ForMember(d => d.CdAard, o => o.MapFrom(s => s.CdAard))
            .ForMember(d => d.CdAardSpecified, o => o.MapFrom(s => s.CdAardSpecified))
            .ForMember(d => d.CdInvlVpl, o => o.MapFrom(s => s.CdInvlVpl))
            .ForMember(d => d.FsIndFZ, o => o.MapFrom(s => s.FsIndFz))
            .ForMember(d => d.FsIndFZSpecified, o => o.MapFrom(s => s.FsIndFzSpecified))
            .ForMember(d => d.CAO, o => o.MapFrom(s => s.Cao))
            .ForMember(d => d.CdCaoInl, o => o.MapFrom(s => s.CdCaoInl))
            .ForMember(d => d.IndArbovOnbepTd, o => o.MapFrom(s => s.IndArbovOnbepTd))
            .ForMember(d => d.IndArbovOnbepTdSpecified, o => o.MapFrom(s => s.IndArbovOnbepTdSpecified))
            .ForMember(d => d.IndSchriftArbov, o => o.MapFrom(s => s.IndSchriftArbov))
            .ForMember(d => d.IndSchriftArbovSpecified, o => o.MapFrom(s => s.IndSchriftArbovSpecified))
            .ForMember(d => d.IndOprov, o => o.MapFrom(s => s.IndOprov))
            .ForMember(d => d.IndOprovSpecified, o => o.MapFrom(s => s.IndOprovSpecified))
            .ForMember(d => d.IndJrurennrm, o => o.MapFrom(s => s.IndJrurennrm))
            .ForMember(d => d.IndJrurennrmSpecified, o => o.MapFrom(s => s.IndJrurennrmSpecified))
            .ForMember(d => d.IndPubAanOnbepTd, o => o.MapFrom(s => s.IndPubAanOnbepTd))
            .ForMember(d => d.IndPubAanOnbepTdSpecified, o => o.MapFrom(s => s.IndPubAanOnbepTdSpecified))
            .ForMember(d => d.IndAvrLkvOudrWn, o => o.MapFrom(s => s.IndAvrLkvOudrWn))
            .ForMember(d => d.IndAvrLkvOudrWnSpecified, o => o.MapFrom(s => s.IndAvrLkvOudrWnSpecified))
            .ForMember(d => d.IndAvrLkvAgWn, o => o.MapFrom(s => s.IndAvrLkvAgWn))
            .ForMember(d => d.IndAvrLkvAgWnSpecified, o => o.MapFrom(s => s.IndAvrLkvAgWnSpecified))
            .ForMember(d => d.IndAvrLkvDgBafSb, o => o.MapFrom(s => s.IndAvrLkvDgBafSb))
            .ForMember(d => d.IndAvrLkvDgBafSbSpecified, o => o.MapFrom(s => s.IndAvrLkvDgBafSbSpecified))
            .ForMember(d => d.IndAvrLkvHpAgWn, o => o.MapFrom(s => s.IndAvrLkvHpAgWn))
            .ForMember(d => d.IndAvrLkvHpAgWnSpecified, o => o.MapFrom(s => s.IndAvrLkvHpAgWnSpecified))
            .ForMember(d => d.IndLhKort, o => o.MapFrom(s => s.IndLhKort))
            .ForMember(d => d.CdRdnGnBijt, o => o.MapFrom(s => s.CdRdnGnBijt))
            .ForMember(d => d.CdRdnGnBijtSpecified, o => o.MapFrom(s => s.CdRdnGnBijtSpecified))
            .ForMember(d => d.LbTab, o => o.MapFrom(s => s.LbTab))
            .ForMember(d => d.IndWAO, o => o.MapFrom(s => s.IndWao))
            .ForMember(d => d.IndWW, o => o.MapFrom(s => s.IndWw))
            .ForMember(d => d.IndZW, o => o.MapFrom(s => s.IndZw))
            .ForMember(d => d.IndWgldOudRegl, o => o.MapFrom(s => s.IndWgldOudRegl))
            .ForMember(d => d.IndWgldOudReglSpecified, o => o.MapFrom(s => s.IndWgldOudReglSpecified))
            .ForMember(d => d.CdZvw, o => o.MapFrom(s => s.CdZvw))
            .ForMember(d => d.IndVakBn, o => o.MapFrom(s => s.IndVakBn))
            .ForMember(d => d.IndVakBnSpecified, o => o.MapFrom(s => s.IndVakBnSpecified))
            .ForMember(d => d.IndSA71, o => o.MapFrom(s => s.IndSa71))
            .ForMember(d => d.IndSA71Specified, o => o.MapFrom(s => s.IndSa71Specified))
            .ForMember(d => d.IndSA72, o => o.MapFrom(s => s.IndSa72))
            .ForMember(d => d.IndSA72Specified, o => o.MapFrom(s => s.IndSa72Specified))
            .ForMember(d => d.IndSA03, o => o.MapFrom(s => s.IndSa03))
            .ForMember(d => d.IndSA03Specified, o => o.MapFrom(s => s.IndSa03Specified))
            .ForMember(d => d.CdIncInkVerm, o => o.MapFrom(s => s.CdIncInkVerm))
            .ForMember(d => d.CdIncInkVermSpecified, o => o.MapFrom(s => s.CdIncInkVermSpecified))
            .ReverseMap();

        CreateMap<SectorType, Globals.Models.Loonheffings.Xsd.Xsd2022.SectorType>()
            .ForMember(d => d.DatAanvSect, o => o.MapFrom(s => s.DatAanvSect))
            .ForMember(d => d.DatEindSect, o => o.MapFrom(s => s.DatEindSect))
            .ForMember(d => d.DatEindSectSpecified, o => o.MapFrom(s => s.DatEindSectSpecified))
            .ForMember(d => d.Sect, o => o.MapFrom(s => s.Sect))
            .ReverseMap();

        CreateMap<InkomstenverhoudingIntrekkingType, Globals.Models.Loonheffings.Xsd.Xsd2022.InkomstenverhoudingIntrekkingType>()
            .ForMember(d => d.NumIV, o => o.MapFrom(s => s.NumIv))
            .ForMember(d => d.SofiNr, o => o.MapFrom(s => s.SofiNr))
            .ForMember(d => d.PersNr, o => o.MapFrom(s => s.PersNr))
            .ReverseMap();

        CreateMap<CollectieveAangifteTijdvakAangifteTypeSaldoCorrectiesVoorgaandTijdvak,
                Globals.Models.Loonheffings.Xsd.Xsd2022.CollectieveAangifteTijdvakAangifteTypeSaldoCorrectiesVoorgaandTijdvak>()
            .ForMember(d => d.DatAanvTv, o => o.MapFrom(s => s.DatAanvTv))
            .ForMember(d => d.DatEindTv, o => o.MapFrom(s => s.DatEindTv))
            .ForMember(d => d.Saldo, o => o.MapFrom(s => s.Saldo))
            .ReverseMap();

        CreateMap<CollectieveAangifteTijdvakAangifteType,
                Globals.Models.Loonheffings.Xsd.Xsd2022.CollectieveAangifteTijdvakAangifteType>()
            .ForMember(d => d.TotLnLbPh, o => o.MapFrom(s => s.TotLnLbPh))
            .ForMember(d => d.TotLnSV, o => o.MapFrom(s => s.TotLnSv))
            .ForMember(d => d.TotPrlnAofAnwLg, o => o.MapFrom(s => s.TotPrlnAofAnwLg))
            .ForMember(d => d.TotPrlnAofAnwHg, o => o.MapFrom(s => s.TotPrlnAofAnwHg))
            .ForMember(d => d.TotPrlnAofAnwUit, o => o.MapFrom(s => s.TotPrlnAofAnwUit))
            .ForMember(d => d.TotPrlnAwfAnwLg, o => o.MapFrom(s => s.TotPrlnAwfAnwLg))
            .ForMember(d => d.TotPrlnAwfAnwHg, o => o.MapFrom(s => s.TotPrlnAwfAnwHg))
            .ForMember(d => d.TotPrlnAwfAnwHz, o => o.MapFrom(s => s.TotPrlnAwfAnwHz))
            .ForMember(d => d.PrLnUFO, o => o.MapFrom(s => s.PrLnUfo))
            .ForMember(d => d.IngLbPh, o => o.MapFrom(s => s.IngLbPh))
            .ForMember(d => d.EHPubUitk, o => o.MapFrom(s => s.EhPubUitk))
            .ForMember(d => d.EHGebrAuto, o => o.MapFrom(s => s.EhGebrAuto))
            .ForMember(d => d.EHVUT, o => o.MapFrom(s => s.Ehvut))
            .ForMember(d => d.EhOvsFrfWrkkstrg, o => o.MapFrom(s => s.EhOvsFrfWrkkstrg))
            .ForMember(d => d.AVZeev, o => o.MapFrom(s => s.AvZeev))
            .ForMember(d => d.VrlAVSO, o => o.MapFrom(s => s.VrlAvso))
            .ForMember(d => d.TotPrAofLg, o => o.MapFrom(s => s.TotPrAofLg))
            .ForMember(d => d.TotPrAofHg, o => o.MapFrom(s => s.TotPrAofHg))
            .ForMember(d => d.TotPrAofUit, o => o.MapFrom(s => s.TotPrAofUit))
            .ForMember(d => d.TotOpslWko, o => o.MapFrom(s => s.TotOpslWko))
            .ForMember(d => d.TotPrGediffWhk, o => o.MapFrom(s => s.TotPrGediffWhk))
            .ForMember(d => d.TotPrAwfLg, o => o.MapFrom(s => s.TotPrAwfLg))
            .ForMember(d => d.TotPrAwfHg, o => o.MapFrom(s => s.TotPrAwfHg))
            .ForMember(d => d.TotPrAwfHz, o => o.MapFrom(s => s.TotPrAwfHz))
            .ForMember(d => d.PrUFO, o => o.MapFrom(s => s.PrUfo))
            .ForMember(d => d.IngBijdrZvw, o => o.MapFrom(s => s.IngBijdrZvw))
            .ForMember(d => d.TotWghZvw, o => o.MapFrom(s => s.TotWghZvw))
            .ForMember(d => d.TotTeBet, o => o.MapFrom(s => s.TotTeBet))
            .ForMember(d => d.TotGen, o => o.MapFrom(s => s.TotGen))
            .ReverseMap();

        CreateMap<CollectieveAangifteType, Globals.Models.Loonheffings.Xsd.Xsd2022.CollectieveAangifteType>()
            .ForMember(d => d.TotLnLbPh, o => o.MapFrom(s => s.TotLnLbPh))
            .ForMember(d => d.TotLnSV, o => o.MapFrom(s => s.TotLnSv))
            .ForMember(d => d.TotPrlnAofAnwLg, o => o.MapFrom(s => s.TotPrlnAofAnwLg))
            .ForMember(d => d.TotPrlnAofAnwHg, o => o.MapFrom(s => s.TotPrlnAofAnwHg))
            .ForMember(d => d.TotPrlnAofAnwUit, o => o.MapFrom(s => s.TotPrlnAofAnwUit))
            .ForMember(d => d.TotPrlnAwfAnwLg, o => o.MapFrom(s => s.TotPrlnAwfAnwLg))
            .ForMember(d => d.TotPrlnAwfAnwHg, o => o.MapFrom(s => s.TotPrlnAwfAnwHg))
            .ForMember(d => d.TotPrlnAwfAnwHz, o => o.MapFrom(s => s.TotPrlnAwfAnwHz))
            .ForMember(d => d.PrLnUFO, o => o.MapFrom(s => s.PrLnUfo))
            .ForMember(d => d.IngLbPh, o => o.MapFrom(s => s.IngLbPh))
            .ForMember(d => d.EHPubUitk, o => o.MapFrom(s => s.EhPubUitk))
            .ForMember(d => d.EHGebrAuto, o => o.MapFrom(s => s.EhGebrAuto))
            .ForMember(d => d.EHVUT, o => o.MapFrom(s => s.Ehvut))
            .ForMember(d => d.EhOvsFrfWrkkstrg, o => o.MapFrom(s => s.EhOvsFrfWrkkstrg))
            .ForMember(d => d.AVZeev, o => o.MapFrom(s => s.AvZeev))
            .ForMember(d => d.VrlAVSO, o => o.MapFrom(s => s.VrlAvso))
            .ForMember(d => d.TotPrAofLg, o => o.MapFrom(s => s.TotPrAofLg))
            .ForMember(d => d.TotPrAofHg, o => o.MapFrom(s => s.TotPrAofHg))
            .ForMember(d => d.TotPrAofUit, o => o.MapFrom(s => s.TotPrAofUit))
            .ForMember(d => d.TotOpslWko, o => o.MapFrom(s => s.TotOpslWko))
            .ForMember(d => d.TotPrGediffWhk, o => o.MapFrom(s => s.TotPrGediffWhk))
            .ForMember(d => d.TotPrAwfLg, o => o.MapFrom(s => s.TotPrAwfLg))
            .ForMember(d => d.TotPrAwfHg, o => o.MapFrom(s => s.TotPrAwfHg))
            .ForMember(d => d.TotPrAwfHz, o => o.MapFrom(s => s.TotPrAwfHz))
            .ForMember(d => d.PrUFO, o => o.MapFrom(s => s.PrUfo))
            .ForMember(d => d.IngBijdrZvw, o => o.MapFrom(s => s.IngBijdrZvw))
            .ForMember(d => d.TotWghZvw, o => o.MapFrom(s => s.TotWghZvw))
            .ForMember(d => d.TotTeBet, o => o.MapFrom(s => s.TotTeBet))
            .ReverseMap();

        CreateMap<BerichtType, Globals.Models.Loonheffings.Xsd.Xsd2022.BerichtType>()
            .ForMember(d => d.IdBer, o => o.MapFrom(s => s.IdBer))
            .ForMember(d => d.DatTdAanm, o => o.MapFrom(s => s.DatTdAanm))
            .ForMember(d => d.ContPers, o => o.MapFrom(s => s.ContPers))
            .ForMember(d => d.TelNr, o => o.MapFrom(s => s.TelNr))
            .ForMember(d => d.RelNr, o => o.MapFrom(s => s.RelNr))
            .ForMember(d => d.GebrSwPakket, o => o.MapFrom(s => s.GebrSwPakket))
            .ReverseMap();

        CreateMap<Globals.Models.Loonheffings.Xsd.Xsd2022.InkomstenperiodeInitieelType, InkomstenPeriodeModel>()
            .ForMember(d => d.DatAanv, o => o.MapFrom(s => s.DatAanv))
            .ForMember(d => d.SrtIv, o => o.MapFrom(s => s.SrtIV.XmlEnumToString()))
            .ForMember(d => d.CdAard, o => o.MapFrom(s => s.CdAard.XmlEnumToString()))
            .ForMember(d => d.CdInvlVpl, o => o.MapFrom(s => s.CdInvlVpl))
            .ForMember(d => d.FsIndFz, o => o.MapFrom(s => s.FsIndFZ.XmlEnumToString()))
            .ForMember(d => d.Cao, o => o.MapFrom(s => s.CAO))
            .ForMember(d => d.CdCaoInl, o => o.MapFrom(s => s.CdCaoInl))
            .ForMember(d => d.IndArbovOnbepTd, o => o.MapFrom(s => s.IndArbovOnbepTd.XmlEnumToString()))
            .ForMember(d => d.IndSchriftArbov, o => o.MapFrom(s => s.IndSchriftArbov.XmlEnumToString()))
            .ForMember(d => d.IndOprov, o => o.MapFrom(s => s.IndOprov.XmlEnumToString()))
            .ForMember(d => d.IndJrurennrm, o => o.MapFrom(s => s.IndJrurennrm.XmlEnumToString()))
            .ForMember(d => d.IndPubAanOnbepTd, o => o.MapFrom(s => s.IndPubAanOnbepTd.XmlEnumToString()))
            .ForMember(d => d.IndAvrLkvOudrWn, o => o.MapFrom(s => s.IndAvrLkvOudrWn.XmlEnumToString()))
            .ForMember(d => d.IndAvrLkvAgWn, o => o.MapFrom(s => s.IndAvrLkvAgWn.XmlEnumToString()))
            .ForMember(d => d.IndAvrLkvDgBafSb, o => o.MapFrom(s => s.IndAvrLkvDgBafSb.XmlEnumToString()))
            .ForMember(d => d.IndAvrLkvHpAgWn, o => o.MapFrom(s => s.IndAvrLkvHpAgWn.XmlEnumToString()))
            .ForMember(d => d.IndLhKort, o => o.MapFrom(s => s.IndLhKort.XmlEnumToString()))
            .ForMember(d => d.CdRdnGnBijt, o => o.MapFrom(s => s.CdRdnGnBijt.XmlEnumToString()))
            .ForMember(d => d.LbTab, o => o.MapFrom(s => s.LbTab.XmlEnumToString()))
            .ForMember(d => d.IndWao, o => o.MapFrom(s => s.IndWAO.XmlEnumToString()))
            .ForMember(d => d.IndWw, o => o.MapFrom(s => s.IndWW.XmlEnumToString()))
            .ForMember(d => d.IndZw, o => o.MapFrom(s => s.IndZW.XmlEnumToString()))
            .ForMember(d => d.IndWgldOudRegl, o => o.MapFrom(s => s.IndWgldOudRegl.XmlEnumToString()))
            .ForMember(d => d.CdZvw, o => o.MapFrom(s => s.CdZvw.XmlEnumToString()))
            .ForMember(d => d.IndVakBn, o => o.MapFrom(s => s.IndVakBn.XmlEnumToString()))
            .ForMember(d => d.IndSa71, o => o.MapFrom(s => s.IndSA71.XmlEnumToString()))
            .ForMember(d => d.IndSa72, o => o.MapFrom(s => s.IndSA72.XmlEnumToString()))
            .ForMember(d => d.IndSa03, o => o.MapFrom(s => s.IndSA03.XmlEnumToString()))
            .ForMember(d => d.CdIncInkVerm, o => o.MapFrom(s => s.CdIncInkVerm.XmlEnumToString()));
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChillX.Framework.Common.Enumeration
{
    public enum Enum_ContentType
    {
        [Description("application_vnd_hzn_3d_crossword - 3D Crossword Plugin")]
        application_vnd_hzn_3d_crossword,
        [Description("video_3gpp - 3GP")]
        video_3gpp,
        [Description("video_3gpp2 - 3GP2")]
        video_3gpp2,
        [Description("application_vnd_mseq - 3GPP MSEQ File")]
        application_vnd_mseq,
        [Description("application_vnd_3m_post_it_notes - 3M Post It Notes")]
        application_vnd_3m_post_it_notes,
        [Description("application_vnd_3gpp_pic_bw_large - 3rd Generation Partnership Project - Pic Large")]
        application_vnd_3gpp_pic_bw_large,
        [Description("application_vnd_3gpp_pic_bw_small - 3rd Generation Partnership Project - Pic Small")]
        application_vnd_3gpp_pic_bw_small,
        [Description("application_vnd_3gpp_pic_bw_var - 3rd Generation Partnership Project - Pic Var")]
        application_vnd_3gpp_pic_bw_var,
        [Description("application_vnd_3gpp2_tcap - 3rd Generation Partnership Project - Transaction Capabilities Application Part")]
        application_vnd_3gpp2_tcap,
        [Description("application_x_7z_compressed - 7-Zip")]
        application_x_7z_compressed,
        [Description("application_x_abiword - AbiWord")]
        application_x_abiword,
        [Description("application_x_ace_compressed - Ace Archive")]
        application_x_ace_compressed,
        [Description("application_vnd_americandynamics_acc - Active Content Compression")]
        application_vnd_americandynamics_acc,
        [Description("application_vnd_acucobol - ACU Cobol")]
        application_vnd_acucobol,
        [Description("application_vnd_acucorp - ACU Cobol")]
        application_vnd_acucorp,
        [Description("audio_adpcm - Adaptive differential pulse-code modulation")]
        audio_adpcm,
        [Description("application_x_authorware_bin - Adobe (Macropedia) Authorware - Binary File")]
        application_x_authorware_bin,
        [Description("application_x_authorware_map - Adobe (Macropedia) Authorware - Map")]
        application_x_authorware_map,
        [Description("application_x_authorware_seg - Adobe (Macropedia) Authorware - Segment File")]
        application_x_authorware_seg,
        [Description("application_vnd_adobe_air_application_installer_package_zip - Adobe AIR Application")]
        application_vnd_adobe_air_application_installer_package_zip,
        [Description("application_x_shockwave_flash - Adobe Flash")]
        application_x_shockwave_flash,
        [Description("application_vnd_adobe_fxp - Adobe Flex Project")]
        application_vnd_adobe_fxp,
        [Description("application_pdf - Adobe Portable Document Format")]
        application_pdf,
        [Description("application_vnd_cups_ppd - Adobe PostScript Printer Description File Format")]
        application_vnd_cups_ppd,
        [Description("application_x_director - Adobe Shockwave Player")]
        application_x_director,
        [Description("application_vnd_adobe_xdp_xml - Adobe XML Data Package")]
        application_vnd_adobe_xdp_xml,
        [Description("application_vnd_adobe_xfdf - Adobe XML Forms Data Format")]
        application_vnd_adobe_xfdf,
        [Description("audio_x_aac - Advanced Audio Coding (AAC)")]
        audio_x_aac,
        [Description("application_vnd_ahead_space - Ahead AIR Application")]
        application_vnd_ahead_space,
        [Description("application_vnd_airzip_filesecure_azf - AirZip FileSECURE")]
        application_vnd_airzip_filesecure_azf,
        [Description("application_vnd_airzip_filesecure_azs - AirZip FileSECURE")]
        application_vnd_airzip_filesecure_azs,
        [Description("application_vnd_amazon_ebook - Amazon Kindle eBook format")]
        application_vnd_amazon_ebook,
        [Description("application_vnd_amiga_ami - AmigaDE")]
        application_vnd_amiga_ami,
        [Description("application_andrew_inset - Andrew Toolkit")]
        application_andrew_inset,
        [Description("application_vnd_android_package_archive - Android Package Archive")]
        application_vnd_android_package_archive,
        [Description("application_vnd_anser_web_certificate_issue_initiation - ANSER-WEB Terminal Client - Certificate Issue")]
        application_vnd_anser_web_certificate_issue_initiation,
        [Description("application_vnd_anser_web_funds_transfer_initiation - ANSER-WEB Terminal Client - Web Funds Transfer")]
        application_vnd_anser_web_funds_transfer_initiation,
        [Description("application_vnd_antix_game_component - Antix Game Player")]
        application_vnd_antix_game_component,
        [Description("application_vnd_apple_installer_xml - Apple Installer Package")]
        application_vnd_apple_installer_xml,
        [Description("application_applixware - Applixware")]
        application_applixware,
        [Description("application_vnd_hhe_lesson_player - Archipelago Lesson Player")]
        application_vnd_hhe_lesson_player,
        [Description("application_vnd_aristanetworks_swi - Arista Networks Software Image")]
        application_vnd_aristanetworks_swi,
        [Description("text_x_asm - Assembler Source File")]
        text_x_asm,
        [Description("application_atomcat_xml - Atom Publishing Protocol")]
        application_atomcat_xml,
        [Description("application_atomsvc_xml - Atom Publishing Protocol Service Document")]
        application_atomsvc_xml,
        [Description("application_atom_xml - Atom Syndication Format")]
        application_atom_xml,
        [Description("application_pkix_attr_cert - Attribute Certificate")]
        application_pkix_attr_cert,
        [Description("audio_x_aiff - Audio Interchange File Format")]
        audio_x_aiff,
        [Description("video_x_msvideo - Audio Video Interleave (AVI)")]
        video_x_msvideo,
        [Description("application_vnd_audiograph - Audiograph")]
        application_vnd_audiograph,
        [Description("image_vnd_dxf - AutoCAD DXF")]
        image_vnd_dxf,
        [Description("model_vnd_dwf - Autodesk Design Web Format (DWF)")]
        model_vnd_dwf,
        [Description("text_plain_bas - BAS Partitur Format")]
        text_plain_bas,
        [Description("application_x_bcpio - Binary CPIO Archive")]
        application_x_bcpio,
        [Description("application_octet_stream - Binary Data")]
        application_octet_stream,
        [Description("image_bmp - Bitmap Image File")]
        image_bmp,
        [Description("application_x_bittorrent - BitTorrent")]
        application_x_bittorrent,
        [Description("application_vnd_rim_cod - Blackberry COD File")]
        application_vnd_rim_cod,
        [Description("application_vnd_blueice_multipass - Blueice Research Multipass")]
        application_vnd_blueice_multipass,
        [Description("application_vnd_bmi - BMI Drawing Data Interchange")]
        application_vnd_bmi,
        [Description("application_x_sh - Bourne Shell Script")]
        application_x_sh,
        [Description("image_prs_btif - BTIF")]
        image_prs_btif,
        [Description("application_vnd_businessobjects - BusinessObjects")]
        application_vnd_businessobjects,
        [Description("application_x_bzip - Bzip Archive")]
        application_x_bzip,
        [Description("application_x_bzip2 - Bzip2 Archive")]
        application_x_bzip2,
        [Description("application_x_csh - C Shell Script")]
        application_x_csh,
        [Description("text_x_c - C Source File")]
        text_x_c,
        [Description("application_vnd_chemdraw_xml - CambridgeSoft Chem Draw")]
        application_vnd_chemdraw_xml,
        [Description("text_css - Cascading Style Sheets (CSS)")]
        text_css,
        [Description("chemical_x_cdx - ChemDraw eXchange file")]
        chemical_x_cdx,
        [Description("chemical_x_cml - Chemical Markup Language")]
        chemical_x_cml,
        [Description("chemical_x_csml - Chemical Style Markup Language")]
        chemical_x_csml,
        [Description("application_vnd_contact_cmsg - CIM Database")]
        application_vnd_contact_cmsg,
        [Description("application_vnd_claymore - Claymore Data Files")]
        application_vnd_claymore,
        [Description("application_vnd_clonk_c4group - Clonk Game")]
        application_vnd_clonk_c4group,
        [Description("image_vnd_dvb_subtitle - Close Captioning - Subtitle")]
        image_vnd_dvb_subtitle,
        [Description("application_cdmi_capability - Cloud Data Management Interface (CDMI) - Capability")]
        application_cdmi_capability,
        [Description("application_cdmi_container - Cloud Data Management Interface (CDMI) - Contaimer")]
        application_cdmi_container,
        [Description("application_cdmi_domain - Cloud Data Management Interface (CDMI) - Domain")]
        application_cdmi_domain,
        [Description("application_cdmi_object - Cloud Data Management Interface (CDMI) - Object")]
        application_cdmi_object,
        [Description("application_cdmi_queue - Cloud Data Management Interface (CDMI) - Queue")]
        application_cdmi_queue,
        [Description("application_vnd_cluetrust_cartomobile_config - ClueTrust CartoMobile - Config")]
        application_vnd_cluetrust_cartomobile_config,
        [Description("application_vnd_cluetrust_cartomobile_config_pkg - ClueTrust CartoMobile - Config Package")]
        application_vnd_cluetrust_cartomobile_config_pkg,
        [Description("image_x_cmu_raster - CMU Image")]
        image_x_cmu_raster,
        [Description("model_vnd_collada_xml - COLLADA")]
        model_vnd_collada_xml,
        [Description("text_csv - Comma-Seperated Values")]
        text_csv,
        [Description("application_mac_compactpro - Compact Pro")]
        application_mac_compactpro,
        [Description("application_vnd_wap_wmlc - Compiled Wireless Markup Language (WMLC)")]
        application_vnd_wap_wmlc,
        [Description("image_cgm - Computer Graphics Metafile")]
        image_cgm,
        [Description("x_conference_x_cooltalk - CoolTalk")]
        x_conference_x_cooltalk,
        [Description("image_x_cmx - Corel Metafile Exchange (CMX)")]
        image_x_cmx,
        [Description("application_vnd_xara - CorelXARA")]
        application_vnd_xara,
        [Description("application_vnd_cosmocaller - CosmoCaller")]
        application_vnd_cosmocaller,
        [Description("application_x_cpio - CPIO Archive")]
        application_x_cpio,
        [Description("application_vnd_crick_clicker - CrickSoftware - Clicker")]
        application_vnd_crick_clicker,
        [Description("application_vnd_crick_clicker_keyboard - CrickSoftware - Clicker - Keyboard")]
        application_vnd_crick_clicker_keyboard,
        [Description("application_vnd_crick_clicker_palette - CrickSoftware - Clicker - Palette")]
        application_vnd_crick_clicker_palette,
        [Description("application_vnd_crick_clicker_template - CrickSoftware - Clicker - Template")]
        application_vnd_crick_clicker_template,
        [Description("application_vnd_crick_clicker_wordbank - CrickSoftware - Clicker - Wordbank")]
        application_vnd_crick_clicker_wordbank,
        [Description("application_vnd_criticaltools_wbs_xml - Critical Tools - PERT Chart EXPERT")]
        application_vnd_criticaltools_wbs_xml,
        [Description("application_vnd_rig_cryptonote - CryptoNote")]
        application_vnd_rig_cryptonote,
        [Description("chemical_x_cif - Crystallographic Interchange Format")]
        chemical_x_cif,
        [Description("chemical_x_cmdf - CrystalMaker Data Format")]
        chemical_x_cmdf,
        [Description("application_cu_seeme - CU-SeeMe")]
        application_cu_seeme,
        [Description("application_prs_cww - CU-Writer")]
        application_prs_cww,
        [Description("text_vnd_curl - Curl - Applet")]
        text_vnd_curl,
        [Description("text_vnd_curl_dcurl - Curl - Detached Applet")]
        text_vnd_curl_dcurl,
        [Description("text_vnd_curl_mcurl - Curl - Manifest File")]
        text_vnd_curl_mcurl,
        [Description("text_vnd_curl_scurl - Curl - Source Code")]
        text_vnd_curl_scurl,
        [Description("application_vnd_curl_car - CURL Applet")]
        application_vnd_curl_car,
        [Description("application_vnd_curl_pcurl - CURL Applet")]
        application_vnd_curl_pcurl,
        [Description("application_vnd_yellowriver_custom_menu - CustomMenu")]
        application_vnd_yellowriver_custom_menu,
        [Description("application_dssc_der - Data Structure for the Security Suitability of Cryptographic Algorithms")]
        application_dssc_der,
        [Description("application_dssc_xml - Data Structure for the Security Suitability of Cryptographic Algorithms")]
        application_dssc_xml,
        [Description("application_x_debian_package - Debian Package")]
        application_x_debian_package,
        [Description("audio_vnd_dece_audio - DECE Audio")]
        audio_vnd_dece_audio,
        [Description("image_vnd_dece_graphic - DECE Graphic")]
        image_vnd_dece_graphic,
        [Description("video_vnd_dece_hd - DECE High Definition Video")]
        video_vnd_dece_hd,
        [Description("video_vnd_dece_mobile - DECE Mobile Video")]
        video_vnd_dece_mobile,
        [Description("video_vnd_uvvu_mp4 - DECE MP4")]
        video_vnd_uvvu_mp4,
        [Description("video_vnd_dece_pd - DECE PD Video")]
        video_vnd_dece_pd,
        [Description("video_vnd_dece_sd - DECE SD Video")]
        video_vnd_dece_sd,
        [Description("video_vnd_dece_video - DECE Video")]
        video_vnd_dece_video,
        [Description("application_x_dvi - Device Independent File Format (DVI)")]
        application_x_dvi,
        [Description("application_vnd_fdsn_seed - Digital Siesmograph Networks - SEED Datafiles")]
        application_vnd_fdsn_seed,
        [Description("application_x_dtbook_xml - Digital Talking Book")]
        application_x_dtbook_xml,
        [Description("application_x_dtbresource_xml - Digital Talking Book - Resource File")]
        application_x_dtbresource_xml,
        [Description("application_vnd_dvb_ait - Digital Video Broadcasting")]
        application_vnd_dvb_ait,
        [Description("application_vnd_dvb_service - Digital Video Broadcasting")]
        application_vnd_dvb_service,
        [Description("audio_vnd_digital_winds - Digital Winds Music")]
        audio_vnd_digital_winds,
        [Description("image_vnd_djvu - DjVu")]
        image_vnd_djvu,
        [Description("application_xml_dtd - Document Type Definition")]
        application_xml_dtd,
        [Description("application_vnd_dolby_mlp - Dolby Meridian Lossless Packing")]
        application_vnd_dolby_mlp,
        [Description("application_x_doom - Doom Video Game")]
        application_x_doom,
        [Description("application_vnd_dpgraph - DPGraph")]
        application_vnd_dpgraph,
        [Description("audio_vnd_dra - DRA Audio")]
        audio_vnd_dra,
        [Description("application_vnd_dreamfactory - DreamFactory")]
        application_vnd_dreamfactory,
        [Description("audio_vnd_dts - DTS Audio")]
        audio_vnd_dts,
        [Description("audio_vnd_dts_hd - DTS High Definition Audio")]
        audio_vnd_dts_hd,
        [Description("image_vnd_dwg - DWG Drawing")]
        image_vnd_dwg,
        [Description("application_vnd_dynageo - DynaGeo")]
        application_vnd_dynageo,
        [Description("application_ecmascript - ECMAScript")]
        application_ecmascript,
        [Description("application_vnd_ecowin_chart - EcoWin Chart")]
        application_vnd_ecowin_chart,
        [Description("image_vnd_fujixerox_edmics_mmr - EDMICS 2000")]
        image_vnd_fujixerox_edmics_mmr,
        [Description("image_vnd_fujixerox_edmics_rlc - EDMICS 2000")]
        image_vnd_fujixerox_edmics_rlc,
        [Description("application_exi - Efficient XML Interchange")]
        application_exi,
        [Description("application_vnd_proteus_magazine - EFI Proteus")]
        application_vnd_proteus_magazine,
        [Description("application_epub_zip - Electronic Publication")]
        application_epub_zip,
        [Description("message_rfc822 - Email Message")]
        message_rfc822,
        [Description("application_vnd_enliven - Enliven Viewer")]
        application_vnd_enliven,
        [Description("application_vnd_is_xpr - Express by Infoseek")]
        application_vnd_is_xpr,
        [Description("image_vnd_xiff - eXtended Image File Format (XIFF)")]
        image_vnd_xiff,
        [Description("application_vnd_xfdl - Extensible Forms Description Language")]
        application_vnd_xfdl,
        [Description("application_emma_xml - Extensible MultiModal Annotation")]
        application_emma_xml,
        [Description("application_vnd_ezpix_album - EZPix Secure Photo Album")]
        application_vnd_ezpix_album,
        [Description("application_vnd_ezpix_package - EZPix Secure Photo Album")]
        application_vnd_ezpix_package,
        [Description("image_vnd_fst - FAST Search & Transfer ASA")]
        image_vnd_fst,
        [Description("video_vnd_fvt - FAST Search & Transfer ASA")]
        video_vnd_fvt,
        [Description("image_vnd_fastbidsheet - FastBid Sheet")]
        image_vnd_fastbidsheet,
        [Description("application_vnd_denovo_fcselayout_link - FCS Express Layout Link")]
        application_vnd_denovo_fcselayout_link,
        [Description("video_x_f4v - Flash Video")]
        video_x_f4v,
        [Description("video_x_flv - Flash Video")]
        video_x_flv,
        [Description("image_vnd_fpx - FlashPix")]
        image_vnd_fpx,
        [Description("image_vnd_net_fpx - FlashPix")]
        image_vnd_net_fpx,
        [Description("text_vnd_fmi_flexstor - FLEXSTOR")]
        text_vnd_fmi_flexstor,
        [Description("video_x_fli - FLI/FLC Animation Format")]
        video_x_fli,
        [Description("application_vnd_fluxtime_clip - FluxTime Clip")]
        application_vnd_fluxtime_clip,
        [Description("application_vnd_fdf - Forms Data Format")]
        application_vnd_fdf,
        [Description("text_x_fortran - Fortran Source File")]
        text_x_fortran,
        [Description("application_vnd_mif - FrameMaker Interchange Format")]
        application_vnd_mif,
        [Description("application_vnd_framemaker - FrameMaker Normal Format")]
        application_vnd_framemaker,
        [Description("image_x_freehand - FreeHand MX")]
        image_x_freehand,
        [Description("application_vnd_fsc_weblaunch - Friendly Software Corporation")]
        application_vnd_fsc_weblaunch,
        [Description("application_vnd_frogans_fnc - Frogans Player")]
        application_vnd_frogans_fnc,
        [Description("application_vnd_frogans_ltf - Frogans Player")]
        application_vnd_frogans_ltf,
        [Description("application_vnd_fujixerox_ddd - Fujitsu - Xerox 2D CAD Data")]
        application_vnd_fujixerox_ddd,
        [Description("application_vnd_fujixerox_docuworks - Fujitsu - Xerox DocuWorks")]
        application_vnd_fujixerox_docuworks,
        [Description("application_vnd_fujixerox_docuworks_binder - Fujitsu - Xerox DocuWorks Binder")]
        application_vnd_fujixerox_docuworks_binder,
        [Description("application_vnd_fujitsu_oasys - Fujitsu Oasys")]
        application_vnd_fujitsu_oasys,
        [Description("application_vnd_fujitsu_oasys2 - Fujitsu Oasys")]
        application_vnd_fujitsu_oasys2,
        [Description("application_vnd_fujitsu_oasys3 - Fujitsu Oasys")]
        application_vnd_fujitsu_oasys3,
        [Description("application_vnd_fujitsu_oasysgp - Fujitsu Oasys")]
        application_vnd_fujitsu_oasysgp,
        [Description("application_vnd_fujitsu_oasysprs - Fujitsu Oasys")]
        application_vnd_fujitsu_oasysprs,
        [Description("application_x_futuresplash - FutureSplash Animator")]
        application_x_futuresplash,
        [Description("application_vnd_fuzzysheet - FuzzySheet")]
        application_vnd_fuzzysheet,
        [Description("image_g3fax - G3 Fax Image")]
        image_g3fax,
        [Description("application_vnd_gmx - GameMaker ActiveX")]
        application_vnd_gmx,
        [Description("model_vnd_gtw - Gen-Trix Studio")]
        model_vnd_gtw,
        [Description("application_vnd_genomatix_tuxedo - Genomatix Tuxedo Framework")]
        application_vnd_genomatix_tuxedo,
        [Description("application_vnd_geogebra_file - GeoGebra")]
        application_vnd_geogebra_file,
        [Description("application_vnd_geogebra_tool - GeoGebra")]
        application_vnd_geogebra_tool,
        [Description("model_vnd_gdl - Geometric Description Language (GDL)")]
        model_vnd_gdl,
        [Description("application_vnd_geometry_explorer - GeoMetry Explorer")]
        application_vnd_geometry_explorer,
        [Description("application_vnd_geonext - GEONExT and JSXGraph")]
        application_vnd_geonext,
        [Description("application_vnd_geoplan - GeoplanW")]
        application_vnd_geoplan,
        [Description("application_vnd_geospace - GeospacW")]
        application_vnd_geospace,
        [Description("application_x_font_ghostscript - Ghostscript Font")]
        application_x_font_ghostscript,
        [Description("application_x_font_bdf - Glyph Bitmap Distribution Format")]
        application_x_font_bdf,
        [Description("application_x_gtar - GNU Tar Files")]
        application_x_gtar,
        [Description("application_x_texinfo - GNU Texinfo Document")]
        application_x_texinfo,
        [Description("application_x_gnumeric - Gnumeric")]
        application_x_gnumeric,
        [Description("application_vnd_google_earth_kml_xml - Google Earth - KML")]
        application_vnd_google_earth_kml_xml,
        [Description("application_vnd_google_earth_kmz - Google Earth - Zipped KML")]
        application_vnd_google_earth_kmz,
        [Description("application_vnd_grafeq - GrafEq")]
        application_vnd_grafeq,
        [Description("image_gif - Graphics Interchange Format")]
        image_gif,
        [Description("text_vnd_graphviz - Graphviz")]
        text_vnd_graphviz,
        [Description("application_vnd_groove_account - Groove - Account")]
        application_vnd_groove_account,
        [Description("application_vnd_groove_help - Groove - Help")]
        application_vnd_groove_help,
        [Description("application_vnd_groove_identity_message - Groove - Identity Message")]
        application_vnd_groove_identity_message,
        [Description("application_vnd_groove_injector - Groove - Injector")]
        application_vnd_groove_injector,
        [Description("application_vnd_groove_tool_message - Groove - Tool Message")]
        application_vnd_groove_tool_message,
        [Description("application_vnd_groove_tool_template - Groove - Tool Template")]
        application_vnd_groove_tool_template,
        [Description("application_vnd_groove_vcard - Groove - Vcard")]
        application_vnd_groove_vcard,
        [Description("video_h261 - H.261")]
        video_h261,
        [Description("video_h263 - H.263")]
        video_h263,
        [Description("video_h264 - H.264")]
        video_h264,
        [Description("application_vnd_hp_hpid - Hewlett Packard Instant Delivery")]
        application_vnd_hp_hpid,
        [Description("application_vnd_hp_hps - Hewlett-Packard's WebPrintSmart")]
        application_vnd_hp_hps,
        [Description("application_x_hdf - Hierarchical Data Format")]
        application_x_hdf,
        [Description("audio_vnd_rip - Hit'n'Mix")]
        audio_vnd_rip,
        [Description("application_vnd_hbci - Homebanking Computer Interface (HBCI)")]
        application_vnd_hbci,
        [Description("application_vnd_hp_jlyt - HP Indigo Digital Press - Job Layout Languate")]
        application_vnd_hp_jlyt,
        [Description("application_vnd_hp_pcl - HP Printer Command Language")]
        application_vnd_hp_pcl,
        [Description("application_vnd_hp_hpgl - HP-GL/2 and HP RTL")]
        application_vnd_hp_hpgl,
        [Description("application_vnd_yamaha_hv_script - HV Script")]
        application_vnd_yamaha_hv_script,
        [Description("application_vnd_yamaha_hv_dic - HV Voice Dictionary")]
        application_vnd_yamaha_hv_dic,
        [Description("application_vnd_yamaha_hv_voice - HV Voice Parameter")]
        application_vnd_yamaha_hv_voice,
        [Description("application_vnd_hydrostatix_sof_data - Hydrostatix Master Suite")]
        application_vnd_hydrostatix_sof_data,
        [Description("application_hyperstudio - Hyperstudio")]
        application_hyperstudio,
        [Description("application_vnd_hal_xml - Hypertext Application Language")]
        application_vnd_hal_xml,
        [Description("text_html - HyperText Markup Language (HTML)")]
        text_html,
        [Description("application_vnd_ibm_rights_management - IBM DB2 Rights Manager")]
        application_vnd_ibm_rights_management,
        [Description("application_vnd_ibm_secure_container - IBM Electronic Media Management System - Secure Container")]
        application_vnd_ibm_secure_container,
        [Description("text_calendar - iCalendar")]
        text_calendar,
        [Description("application_vnd_iccprofile - ICC profile")]
        application_vnd_iccprofile,
        [Description("image_x_icon - Icon Image")]
        image_x_icon,
        [Description("application_vnd_igloader - igLoader")]
        application_vnd_igloader,
        [Description("image_ief - Image Exchange Format")]
        image_ief,
        [Description("application_vnd_immervision_ivp - ImmerVision PURE Players")]
        application_vnd_immervision_ivp,
        [Description("application_vnd_immervision_ivu - ImmerVision PURE Players")]
        application_vnd_immervision_ivu,
        [Description("application_reginfo_xml - IMS Networks")]
        application_reginfo_xml,
        [Description("text_vnd_in3d_3dml - In3D - 3DML")]
        text_vnd_in3d_3dml,
        [Description("text_vnd_in3d_spot - In3D - 3DML")]
        text_vnd_in3d_spot,
        [Description("model_iges - Initial Graphics Exchange Specification (IGES)")]
        model_iges,
        [Description("application_vnd_intergeo - Interactive Geometry Software")]
        application_vnd_intergeo,
        [Description("application_vnd_cinderella - Interactive Geometry Software Cinderella")]
        application_vnd_cinderella,
        [Description("application_vnd_intercon_formnet - Intercon FormNet")]
        application_vnd_intercon_formnet,
        [Description("application_vnd_isac_fcs - International Society for Advancement of Cytometry")]
        application_vnd_isac_fcs,
        [Description("application_ipfix - Internet Protocol Flow Information Export")]
        application_ipfix,
        [Description("application_pkix_cert - Internet Public Key Infrastructure - Certificate")]
        application_pkix_cert,
        [Description("application_pkixcmp - Internet Public Key Infrastructure - Certificate Management Protocole")]
        application_pkixcmp,
        [Description("application_pkix_crl - Internet Public Key Infrastructure - Certificate Revocation Lists")]
        application_pkix_crl,
        [Description("application_pkix_pkipath - Internet Public Key Infrastructure - Certification Path")]
        application_pkix_pkipath,
        [Description("application_vnd_insors_igm - IOCOM Visimeet")]
        application_vnd_insors_igm,
        [Description("application_vnd_ipunplugged_rcprofile - IP Unplugged Roaming Client")]
        application_vnd_ipunplugged_rcprofile,
        [Description("application_vnd_irepository_package_xml - iRepository / Lucidoc Editor")]
        application_vnd_irepository_package_xml,
        [Description("text_vnd_sun_j2me_app_descriptor - J2ME App Descriptor")]
        text_vnd_sun_j2me_app_descriptor,
        [Description("application_java_archive - Java Archive")]
        application_java_archive,
        [Description("application_java_vm - Java Bytecode File")]
        application_java_vm,
        [Description("application_x_java_jnlp_file - Java Network Launching Protocol")]
        application_x_java_jnlp_file,
        [Description("application_java_serialized_object - Java Serialized Object")]
        application_java_serialized_object,
        [Description("text_x_java_source,java - Java Source File")]
        text_x_java_source, java,
        [Description("application_javascript - JavaScript")]
        application_javascript,
        [Description("application_json - JavaScript Object Notation (JSON)")]
        application_json,
        [Description("application_vnd_joost_joda_archive - Joda Archive")]
        application_vnd_joost_joda_archive,
        [Description("video_jpm - JPEG 2000 Compound Image File Format")]
        video_jpm,
        [Description("image_jpeg - JPEG Image")]
        image_jpeg,
        [Description("image_x_citrix_jpeg - JPEG Image (Citrix client)")]
        image_x_citrix_jpeg,
        [Description("image_pjpeg - JPEG Image (Progressive)")]
        image_pjpeg,
        [Description("video_jpeg - JPGVideo")]
        video_jpeg,
        [Description("application_vnd_kahootz - Kahootz")]
        application_vnd_kahootz,
        [Description("application_vnd_chipnuts_karaoke_mmd - Karaoke on Chipnuts Chipsets")]
        application_vnd_chipnuts_karaoke_mmd,
        [Description("application_vnd_kde_karbon - KDE KOffice Office Suite - Karbon")]
        application_vnd_kde_karbon,
        [Description("application_vnd_kde_kchart - KDE KOffice Office Suite - KChart")]
        application_vnd_kde_kchart,
        [Description("application_vnd_kde_kformula - KDE KOffice Office Suite - Kformula")]
        application_vnd_kde_kformula,
        [Description("application_vnd_kde_kivio - KDE KOffice Office Suite - Kivio")]
        application_vnd_kde_kivio,
        [Description("application_vnd_kde_kontour - KDE KOffice Office Suite - Kontour")]
        application_vnd_kde_kontour,
        [Description("application_vnd_kde_kpresenter - KDE KOffice Office Suite - Kpresenter")]
        application_vnd_kde_kpresenter,
        [Description("application_vnd_kde_kspread - KDE KOffice Office Suite - Kspread")]
        application_vnd_kde_kspread,
        [Description("application_vnd_kde_kword - KDE KOffice Office Suite - Kword")]
        application_vnd_kde_kword,
        [Description("application_vnd_kenameaapp - Kenamea App")]
        application_vnd_kenameaapp,
        [Description("application_vnd_kidspiration - Kidspiration")]
        application_vnd_kidspiration,
        [Description("application_vnd_kinar - Kinar Applications")]
        application_vnd_kinar,
        [Description("application_vnd_kodak_descriptor - Kodak Storyshare")]
        application_vnd_kodak_descriptor,
        [Description("application_vnd_las_las_xml - Laser App Enterprise")]
        application_vnd_las_las_xml,
        [Description("application_x_latex - LaTeX")]
        application_x_latex,
        [Description("application_vnd_llamagraphics_life_balance_desktop - Life Balance - Desktop Edition")]
        application_vnd_llamagraphics_life_balance_desktop,
        [Description("application_vnd_llamagraphics_life_balance_exchange_xml - Life Balance - Exchange Format")]
        application_vnd_llamagraphics_life_balance_exchange_xml,
        [Description("application_vnd_jam - Lightspeed Audio Lab")]
        application_vnd_jam,
        [Description("application_vnd_lotus_1_2_3 - Lotus 1-2-3")]
        application_vnd_lotus_1_2_3,
        [Description("application_vnd_lotus_approach - Lotus Approach")]
        application_vnd_lotus_approach,
        [Description("application_vnd_lotus_freelance - Lotus Freelance")]
        application_vnd_lotus_freelance,
        [Description("application_vnd_lotus_notes - Lotus Notes")]
        application_vnd_lotus_notes,
        [Description("application_vnd_lotus_organizer - Lotus Organizer")]
        application_vnd_lotus_organizer,
        [Description("application_vnd_lotus_screencam - Lotus Screencam")]
        application_vnd_lotus_screencam,
        [Description("application_vnd_lotus_wordpro - Lotus Wordpro")]
        application_vnd_lotus_wordpro,
        [Description("audio_vnd_lucent_voice - Lucent Voice")]
        audio_vnd_lucent_voice,
        [Description("audio_x_mpegurl - M3U (Multimedia Playlist)")]
        audio_x_mpegurl,
        [Description("video_x_m4v - M4v")]
        video_x_m4v,
        [Description("application_mac_binhex40 - Macintosh BinHex 4.0")]
        application_mac_binhex40,
        [Description("application_vnd_macports_portpkg - MacPorts Port System")]
        application_vnd_macports_portpkg,
        [Description("application_vnd_osgeo_mapguide_package - MapGuide DBXML")]
        application_vnd_osgeo_mapguide_package,
        [Description("application_marc - MARC Formats")]
        application_marc,
        [Description("application_marcxml_xml - MARC21 XML Schema")]
        application_marcxml_xml,
        [Description("application_mxf - Material Exchange Format")]
        application_mxf,
        [Description("application_vnd_wolfram_player - Mathematica Notebook Player")]
        application_vnd_wolfram_player,
        [Description("application_mathematica - Mathematica Notebooks")]
        application_mathematica,
        [Description("application_mathml_xml - Mathematical Markup Language")]
        application_mathml_xml,
        [Description("application_mbox - Mbox database files")]
        application_mbox,
        [Description("application_vnd_medcalcdata - MedCalc")]
        application_vnd_medcalcdata,
        [Description("application_mediaservercontrol_xml - Media Server Control Markup Language")]
        application_mediaservercontrol_xml,
        [Description("application_vnd_mediastation_cdkey - MediaRemote")]
        application_vnd_mediastation_cdkey,
        [Description("application_vnd_mfer - Medical Waveform Encoding Format")]
        application_vnd_mfer,
        [Description("application_vnd_mfmp - Melody Format for Mobile Platform")]
        application_vnd_mfmp,
        [Description("model_mesh - Mesh Data Type")]
        model_mesh,
        [Description("application_mads_xml - Metadata Authority Description Schema")]
        application_mads_xml,
        [Description("application_mets_xml - Metadata Encoding and Transmission Standard")]
        application_mets_xml,
        [Description("application_mods_xml - Metadata Object Description Schema")]
        application_mods_xml,
        [Description("application_metalink4_xml - Metalink")]
        application_metalink4_xml,
        [Description("application_vnd_mcd - Micro CADAM Helix D&D")]
        application_vnd_mcd,
        [Description("application_vnd_micrografx_flo - Micrografx")]
        application_vnd_micrografx_flo,
        [Description("application_vnd_micrografx_igx - Micrografx iGrafx Professional")]
        application_vnd_micrografx_igx,
        [Description("application_vnd_eszigno3_xml - MICROSEC e-Szign¢")]
        application_vnd_eszigno3_xml,
        [Description("application_x_msaccess - Microsoft Access")]
        application_x_msaccess,
        [Description("video_x_ms_asf - Microsoft Advanced Systems Format (ASF)")]
        video_x_ms_asf,
        [Description("application_x_msdownload - Microsoft Application")]
        application_x_msdownload,
        [Description("application_vnd_ms_artgalry - Microsoft Artgalry")]
        application_vnd_ms_artgalry,
        [Description("application_vnd_ms_cab_compressed - Microsoft Cabinet File")]
        application_vnd_ms_cab_compressed,
        [Description("application_vnd_ms_ims - Microsoft Class Server")]
        application_vnd_ms_ims,
        [Description("application_x_ms_application - Microsoft ClickOnce")]
        application_x_ms_application,
        [Description("application_x_msclip - Microsoft Clipboard Clip")]
        application_x_msclip,
        [Description("image_vnd_ms_modi - Microsoft Document Imaging Format")]
        image_vnd_ms_modi,
        [Description("application_vnd_ms_fontobject - Microsoft Embedded OpenType")]
        application_vnd_ms_fontobject,
        [Description("application_vnd_ms_excel - Microsoft Excel")]
        application_vnd_ms_excel,
        [Description("application_vnd_ms_excel_addin_macroenabled_12 - Microsoft Excel - Add-In File")]
        application_vnd_ms_excel_addin_macroenabled_12,
        [Description("application_vnd_ms_excel_sheet_binary_macroenabled_12 - Microsoft Excel - Binary Workbook")]
        application_vnd_ms_excel_sheet_binary_macroenabled_12,
        [Description("application_vnd_ms_excel_template_macroenabled_12 - Microsoft Excel - Macro-Enabled Template File")]
        application_vnd_ms_excel_template_macroenabled_12,
        [Description("application_vnd_ms_excel_sheet_macroenabled_12 - Microsoft Excel - Macro-Enabled Workbook")]
        application_vnd_ms_excel_sheet_macroenabled_12,
        [Description("application_vnd_ms_htmlhelp - Microsoft Html Help File")]
        application_vnd_ms_htmlhelp,
        [Description("application_x_mscardfile - Microsoft Information Card")]
        application_x_mscardfile,
        [Description("application_vnd_ms_lrm - Microsoft Learning Resource Module")]
        application_vnd_ms_lrm,
        [Description("application_x_msmediaview - Microsoft MediaView")]
        application_x_msmediaview,
        [Description("application_x_msmoney - Microsoft Money")]
        application_x_msmoney,
        [Description("application_vnd_openxmlformats_officedocument_presentationml_presentation - Microsoft Office - OOXML - Presentation")]
        application_vnd_openxmlformats_officedocument_presentationml_presentation,
        [Description("application_vnd_openxmlformats_officedocument_presentationml_slide - Microsoft Office - OOXML - Presentation (Slide)")]
        application_vnd_openxmlformats_officedocument_presentationml_slide,
        [Description("application_vnd_openxmlformats_officedocument_presentationml_slideshow - Microsoft Office - OOXML - Presentation (Slideshow)")]
        application_vnd_openxmlformats_officedocument_presentationml_slideshow,
        [Description("application_vnd_openxmlformats_officedocument_presentationml_template - Microsoft Office - OOXML - Presentation Template")]
        application_vnd_openxmlformats_officedocument_presentationml_template,
        [Description("application_vnd_openxmlformats_officedocument_spreadsheetml_sheet - Microsoft Office - OOXML - Spreadsheet")]
        application_vnd_openxmlformats_officedocument_spreadsheetml_sheet,
        [Description("application_vnd_openxmlformats_officedocument_spreadsheetml_template - Microsoft Office - OOXML - Spreadsheet Template")]
        application_vnd_openxmlformats_officedocument_spreadsheetml_template,
        [Description("application_vnd_openxmlformats_officedocument_wordprocessingml_document - Microsoft Office - OOXML - Word Document")]
        application_vnd_openxmlformats_officedocument_wordprocessingml_document,
        [Description("application_vnd_openxmlformats_officedocument_wordprocessingml_template - Microsoft Office - OOXML - Word Document Template")]
        application_vnd_openxmlformats_officedocument_wordprocessingml_template,
        [Description("application_x_msbinder - Microsoft Office Binder")]
        application_x_msbinder,
        [Description("application_vnd_ms_officetheme - Microsoft Office System Release Theme")]
        application_vnd_ms_officetheme,
        [Description("application_onenote - Microsoft OneNote")]
        application_onenote,
        [Description("audio_vnd_ms_playready_media_pya - Microsoft PlayReady Ecosystem")]
        audio_vnd_ms_playready_media_pya,
        [Description("video_vnd_ms_playready_media_pyv - Microsoft PlayReady Ecosystem Video")]
        video_vnd_ms_playready_media_pyv,
        [Description("application_vnd_ms_powerpoint - Microsoft PowerPoint")]
        application_vnd_ms_powerpoint,
        [Description("application_vnd_ms_powerpoint_addin_macroenabled_12 - Microsoft PowerPoint - Add-in file")]
        application_vnd_ms_powerpoint_addin_macroenabled_12,
        [Description("application_vnd_ms_powerpoint_slide_macroenabled_12 - Microsoft PowerPoint - Macro-Enabled Open XML Slide")]
        application_vnd_ms_powerpoint_slide_macroenabled_12,
        [Description("application_vnd_ms_powerpoint_presentation_macroenabled_12 - Microsoft PowerPoint - Macro-Enabled Presentation File")]
        application_vnd_ms_powerpoint_presentation_macroenabled_12,
        [Description("application_vnd_ms_powerpoint_slideshow_macroenabled_12 - Microsoft PowerPoint - Macro-Enabled Slide Show File")]
        application_vnd_ms_powerpoint_slideshow_macroenabled_12,
        [Description("application_vnd_ms_powerpoint_template_macroenabled_12 - Microsoft PowerPoint - Macro-Enabled Template File")]
        application_vnd_ms_powerpoint_template_macroenabled_12,
        [Description("application_vnd_ms_project - Microsoft Project")]
        application_vnd_ms_project,
        [Description("application_x_mspublisher - Microsoft Publisher")]
        application_x_mspublisher,
        [Description("application_x_msschedule - Microsoft Schedule+")]
        application_x_msschedule,
        [Description("application_x_silverlight_app - Microsoft Silverlight")]
        application_x_silverlight_app,
        [Description("application_vnd_ms_pki_stl - Microsoft Trust UI Provider - Certificate Trust Link")]
        application_vnd_ms_pki_stl,
        [Description("application_vnd_ms_pki_seccat - Microsoft Trust UI Provider - Security Catalog")]
        application_vnd_ms_pki_seccat,
        [Description("application_vnd_visio - Microsoft Visio")]
        application_vnd_visio,
        [Description("application_vnd_visio2013 - Microsoft Visio 2013")]
        application_vnd_visio2013,
        [Description("video_x_ms_wm - Microsoft Windows Media")]
        video_x_ms_wm,
        [Description("audio_x_ms_wma - Microsoft Windows Media Audio")]
        audio_x_ms_wma,
        [Description("audio_x_ms_wax - Microsoft Windows Media Audio Redirector")]
        audio_x_ms_wax,
        [Description("video_x_ms_wmx - Microsoft Windows Media Audio/Video Playlist")]
        video_x_ms_wmx,
        [Description("application_x_ms_wmd - Microsoft Windows Media Player Download Package")]
        application_x_ms_wmd,
        [Description("application_vnd_ms_wpl - Microsoft Windows Media Player Playlist")]
        application_vnd_ms_wpl,
        [Description("application_x_ms_wmz - Microsoft Windows Media Player Skin Package")]
        application_x_ms_wmz,
        [Description("video_x_ms_wmv - Microsoft Windows Media Video")]
        video_x_ms_wmv,
        [Description("video_x_ms_wvx - Microsoft Windows Media Video Playlist")]
        video_x_ms_wvx,
        [Description("application_x_msmetafile - Microsoft Windows Metafile")]
        application_x_msmetafile,
        [Description("application_x_msterminal - Microsoft Windows Terminal Services")]
        application_x_msterminal,
        [Description("application_msword - Microsoft Word")]
        application_msword,
        [Description("application_vnd_ms_word_document_macroenabled_12 - Microsoft Word - Macro-Enabled Document")]
        application_vnd_ms_word_document_macroenabled_12,
        [Description("application_vnd_ms_word_template_macroenabled_12 - Microsoft Word - Macro-Enabled Template")]
        application_vnd_ms_word_template_macroenabled_12,
        [Description("application_x_mswrite - Microsoft Wordpad")]
        application_x_mswrite,
        [Description("application_vnd_ms_works - Microsoft Works")]
        application_vnd_ms_works,
        [Description("application_x_ms_xbap - Microsoft XAML Browser Application")]
        application_x_ms_xbap,
        [Description("application_vnd_ms_xpsdocument - Microsoft XML Paper Specification")]
        application_vnd_ms_xpsdocument,
        [Description("audio_midi - MIDI - Musical Instrument Digital Interface")]
        audio_midi,
        [Description("application_vnd_ibm_minipay - MiniPay")]
        application_vnd_ibm_minipay,
        [Description("application_vnd_ibm_modcap - MO:DCA-P")]
        application_vnd_ibm_modcap,
        [Description("application_vnd_jcp_javame_midlet_rms - Mobile Information Device Profile")]
        application_vnd_jcp_javame_midlet_rms,
        [Description("application_vnd_tmobile_livetv - MobileTV")]
        application_vnd_tmobile_livetv,
        [Description("application_x_mobipocket_ebook - Mobipocket")]
        application_x_mobipocket_ebook,
        [Description("application_vnd_mobius_mbk - Mobius Management Systems - Basket file")]
        application_vnd_mobius_mbk,
        [Description("application_vnd_mobius_dis - Mobius Management Systems - Distribution Database")]
        application_vnd_mobius_dis,
        [Description("application_vnd_mobius_plc - Mobius Management Systems - Policy Definition Language File")]
        application_vnd_mobius_plc,
        [Description("application_vnd_mobius_mqy - Mobius Management Systems - Query File")]
        application_vnd_mobius_mqy,
        [Description("application_vnd_mobius_msl - Mobius Management Systems - Script Language")]
        application_vnd_mobius_msl,
        [Description("application_vnd_mobius_txf - Mobius Management Systems - Topic Index File")]
        application_vnd_mobius_txf,
        [Description("application_vnd_mobius_daf - Mobius Management Systems - UniversalArchive")]
        application_vnd_mobius_daf,
        [Description("text_vnd_fly - mod_fly / fly.cgi")]
        text_vnd_fly,
        [Description("application_vnd_mophun_certificate - Mophun Certificate")]
        application_vnd_mophun_certificate,
        [Description("application_vnd_mophun_application - Mophun VM")]
        application_vnd_mophun_application,
        [Description("video_mj2 - Motion JPEG 2000")]
        video_mj2,
        [Description("audio_mpeg - MPEG Audio")]
        audio_mpeg,
        [Description("video_vnd_mpegurl - MPEG Url")]
        video_vnd_mpegurl,
        [Description("video_mpeg - MPEG Video")]
        video_mpeg,
        [Description("application_mp21 - MPEG-21")]
        application_mp21,
        [Description("audio_mp4 - MPEG-4 Audio")]
        audio_mp4,
        [Description("video_mp4 - MPEG-4 Video")]
        video_mp4,
        [Description("application_mp4 - MPEG4")]
        application_mp4,
        [Description("application_vnd_apple_mpegurl - Multimedia Playlist Unicode")]
        application_vnd_apple_mpegurl,
        [Description("application_vnd_musician - MUsical Score Interpreted Code Invented for the ASCII designation of Notation")]
        application_vnd_musician,
        [Description("application_vnd_muvee_style - Muvee Automatic Video Editing")]
        application_vnd_muvee_style,
        [Description("application_xv_xml - MXML")]
        application_xv_xml,
        [Description("application_vnd_nokia_n_gage_data - N-Gage Game Data")]
        application_vnd_nokia_n_gage_data,
        [Description("application_vnd_nokia_n_gage_symbian_install - N-Gage Game Installer")]
        application_vnd_nokia_n_gage_symbian_install,
        [Description("application_x_dtbncx_xml - Navigation Control file for XML (for ePub)")]
        application_x_dtbncx_xml,
        [Description("application_x_netcdf - Network Common Data Form (NetCDF)")]
        application_x_netcdf,
        [Description("application_vnd_neurolanguage_nlu - neuroLanguage")]
        application_vnd_neurolanguage_nlu,
        [Description("application_vnd_dna - New Moon Liftoff/DNA")]
        application_vnd_dna,
        [Description("application_vnd_noblenet_directory - NobleNet Directory")]
        application_vnd_noblenet_directory,
        [Description("application_vnd_noblenet_sealer - NobleNet Sealer")]
        application_vnd_noblenet_sealer,
        [Description("application_vnd_noblenet_web - NobleNet Web")]
        application_vnd_noblenet_web,
        [Description("application_vnd_nokia_radio_preset - Nokia Radio Application - Preset")]
        application_vnd_nokia_radio_preset,
        [Description("application_vnd_nokia_radio_presets - Nokia Radio Application - Preset")]
        application_vnd_nokia_radio_presets,
        [Description("text_n3 - Notation3")]
        text_n3,
        [Description("application_vnd_novadigm_edm - Novadigm's RADIA and EDM products")]
        application_vnd_novadigm_edm,
        [Description("application_vnd_novadigm_edx - Novadigm's RADIA and EDM products")]
        application_vnd_novadigm_edx,
        [Description("application_vnd_novadigm_ext - Novadigm's RADIA and EDM products")]
        application_vnd_novadigm_ext,
        [Description("application_vnd_flographit - NpGraphIt")]
        application_vnd_flographit,
        [Description("audio_vnd_nuera_ecelp4800 - Nuera ECELP 4800")]
        audio_vnd_nuera_ecelp4800,
        [Description("audio_vnd_nuera_ecelp7470 - Nuera ECELP 7470")]
        audio_vnd_nuera_ecelp7470,
        [Description("audio_vnd_nuera_ecelp9600 - Nuera ECELP 9600")]
        audio_vnd_nuera_ecelp9600,
        [Description("application_oda - Office Document Architecture")]
        application_oda,
        [Description("application_ogg - Ogg")]
        application_ogg,
        [Description("audio_ogg - Ogg Audio")]
        audio_ogg,
        [Description("video_ogg - Ogg Video")]
        video_ogg,
        [Description("application_vnd_oma_dd2_xml - OMA Download Agents")]
        application_vnd_oma_dd2_xml,
        [Description("application_vnd_oasis_opendocument_text_web - Open Document Text Web")]
        application_vnd_oasis_opendocument_text_web,
        [Description("application_oebps_package_xml - Open eBook Publication Structure")]
        application_oebps_package_xml,
        [Description("application_vnd_intu_qbo - Open Financial Exchange")]
        application_vnd_intu_qbo,
        [Description("application_vnd_openofficeorg_extension - Open Office Extension")]
        application_vnd_openofficeorg_extension,
        [Description("application_vnd_yamaha_openscoreformat - Open Score Format")]
        application_vnd_yamaha_openscoreformat,
        [Description("audio_webm - Open Web Media Project - Audio")]
        audio_webm,
        [Description("video_webm - Open Web Media Project - Video")]
        video_webm,
        [Description("application_vnd_oasis_opendocument_chart - OpenDocument Chart")]
        application_vnd_oasis_opendocument_chart,
        [Description("application_vnd_oasis_opendocument_chart_template - OpenDocument Chart Template")]
        application_vnd_oasis_opendocument_chart_template,
        [Description("application_vnd_oasis_opendocument_database - OpenDocument Database")]
        application_vnd_oasis_opendocument_database,
        [Description("application_vnd_oasis_opendocument_formula - OpenDocument Formula")]
        application_vnd_oasis_opendocument_formula,
        [Description("application_vnd_oasis_opendocument_formula_template - OpenDocument Formula Template")]
        application_vnd_oasis_opendocument_formula_template,
        [Description("application_vnd_oasis_opendocument_graphics - OpenDocument Graphics")]
        application_vnd_oasis_opendocument_graphics,
        [Description("application_vnd_oasis_opendocument_graphics_template - OpenDocument Graphics Template")]
        application_vnd_oasis_opendocument_graphics_template,
        [Description("application_vnd_oasis_opendocument_image - OpenDocument Image")]
        application_vnd_oasis_opendocument_image,
        [Description("application_vnd_oasis_opendocument_image_template - OpenDocument Image Template")]
        application_vnd_oasis_opendocument_image_template,
        [Description("application_vnd_oasis_opendocument_presentation - OpenDocument Presentation")]
        application_vnd_oasis_opendocument_presentation,
        [Description("application_vnd_oasis_opendocument_presentation_template - OpenDocument Presentation Template")]
        application_vnd_oasis_opendocument_presentation_template,
        [Description("application_vnd_oasis_opendocument_spreadsheet - OpenDocument Spreadsheet")]
        application_vnd_oasis_opendocument_spreadsheet,
        [Description("application_vnd_oasis_opendocument_spreadsheet_template - OpenDocument Spreadsheet Template")]
        application_vnd_oasis_opendocument_spreadsheet_template,
        [Description("application_vnd_oasis_opendocument_text - OpenDocument Text")]
        application_vnd_oasis_opendocument_text,
        [Description("application_vnd_oasis_opendocument_text_master - OpenDocument Text Master")]
        application_vnd_oasis_opendocument_text_master,
        [Description("application_vnd_oasis_opendocument_text_template - OpenDocument Text Template")]
        application_vnd_oasis_opendocument_text_template,
        [Description("image_ktx - OpenGL Textures (KTX)")]
        image_ktx,
        [Description("application_vnd_sun_xml_calc - OpenOffice - Calc (Spreadsheet)")]
        application_vnd_sun_xml_calc,
        [Description("application_vnd_sun_xml_calc_template - OpenOffice - Calc Template (Spreadsheet)")]
        application_vnd_sun_xml_calc_template,
        [Description("application_vnd_sun_xml_draw - OpenOffice - Draw (Graphics)")]
        application_vnd_sun_xml_draw,
        [Description("application_vnd_sun_xml_draw_template - OpenOffice - Draw Template (Graphics)")]
        application_vnd_sun_xml_draw_template,
        [Description("application_vnd_sun_xml_impress - OpenOffice - Impress (Presentation)")]
        application_vnd_sun_xml_impress,
        [Description("application_vnd_sun_xml_impress_template - OpenOffice - Impress Template (Presentation)")]
        application_vnd_sun_xml_impress_template,
        [Description("application_vnd_sun_xml_math - OpenOffice - Math (Formula)")]
        application_vnd_sun_xml_math,
        [Description("application_vnd_sun_xml_writer - OpenOffice - Writer (Text - HTML)")]
        application_vnd_sun_xml_writer,
        [Description("application_vnd_sun_xml_writer_global - OpenOffice - Writer (Text - HTML)")]
        application_vnd_sun_xml_writer_global,
        [Description("application_vnd_sun_xml_writer_template - OpenOffice - Writer Template (Text - HTML)")]
        application_vnd_sun_xml_writer_template,
        [Description("application_x_font_otf - OpenType Font File")]
        application_x_font_otf,
        [Description("application_vnd_yamaha_openscoreformat_osfpvg_xml - OSFPVG")]
        application_vnd_yamaha_openscoreformat_osfpvg_xml,
        [Description("application_vnd_osgi_dp - OSGi Deployment Package")]
        application_vnd_osgi_dp,
        [Description("application_vnd_palm - PalmOS Data")]
        application_vnd_palm,
        [Description("text_x_pascal - Pascal Source File")]
        text_x_pascal,
        [Description("application_vnd_pawaafile - PawaaFILE")]
        application_vnd_pawaafile,
        [Description("application_vnd_hp_pclxl - PCL 6 Enhanced (Formely PCL XL)")]
        application_vnd_hp_pclxl,
        [Description("application_vnd_picsel - Pcsel eFIF File")]
        application_vnd_picsel,
        [Description("image_x_pcx - PCX Image")]
        image_x_pcx,
        [Description("image_vnd_adobe_photoshop - Photoshop Document")]
        image_vnd_adobe_photoshop,
        [Description("application_pics_rules - PICSRules")]
        application_pics_rules,
        [Description("image_x_pict - PICT Image")]
        image_x_pict,
        [Description("application_x_chat - pIRCh")]
        application_x_chat,
        [Description("application_pkcs10 - PKCS #10 - Certification Request Standard")]
        application_pkcs10,
        [Description("application_x_pkcs12 - PKCS #12 - Personal Information Exchange Syntax Standard")]
        application_x_pkcs12,
        [Description("application_pkcs7_mime - PKCS #7 - Cryptographic Message Syntax Standard")]
        application_pkcs7_mime,
        [Description("application_pkcs7_signature - PKCS #7 - Cryptographic Message Syntax Standard")]
        application_pkcs7_signature,
        [Description("application_x_pkcs7_certreqresp - PKCS #7 - Cryptographic Message Syntax Standard (Certificate Request Response)")]
        application_x_pkcs7_certreqresp,
        [Description("application_x_pkcs7_certificates - PKCS #7 - Cryptographic Message Syntax Standard (Certificates)")]
        application_x_pkcs7_certificates,
        [Description("application_pkcs8 - PKCS #8 - Private-Key Information Syntax Standard")]
        application_pkcs8,
        [Description("application_vnd_pocketlearn - PocketLearn Viewers")]
        application_vnd_pocketlearn,
        [Description("image_x_portable_anymap - Portable Anymap Image")]
        image_x_portable_anymap,
        [Description("image_x_portable_bitmap - Portable Bitmap Format")]
        image_x_portable_bitmap,
        [Description("application_x_font_pcf - Portable Compiled Format")]
        application_x_font_pcf,
        [Description("application_font_tdpfr - Portable Font Resource")]
        application_font_tdpfr,
        [Description("application_x_chess_pgn - Portable Game Notation (Chess Games)")]
        application_x_chess_pgn,
        [Description("image_x_portable_graymap - Portable Graymap Format")]
        image_x_portable_graymap,
        [Description("image_png - Portable Network Graphics (PNG)")]
        image_png,
        [Description("image_x_citrix_png - Portable Network Graphics (PNG) (Citrix client)")]
        image_x_citrix_png,
        [Description("image_x_png - Portable Network Graphics (PNG) (x-token)")]
        image_x_png,
        [Description("image_x_portable_pixmap - Portable Pixmap Format")]
        image_x_portable_pixmap,
        [Description("application_pskc_xml - Portable Symmetric Key Container")]
        application_pskc_xml,
        [Description("application_vnd_ctc_posml - PosML")]
        application_vnd_ctc_posml,
        [Description("application_postscript - PostScript")]
        application_postscript,
        [Description("application_x_font_type1 - PostScript Fonts")]
        application_x_font_type1,
        [Description("application_vnd_powerbuilder6 - PowerBuilder")]
        application_vnd_powerbuilder6,
        [Description("application_pgp_encrypted - Pretty Good Privacy")]
        application_pgp_encrypted,
        [Description("application_pgp_signature - Pretty Good Privacy - Signature")]
        application_pgp_signature,
        [Description("application_vnd_previewsystems_box - Preview Systems ZipLock/VBox")]
        application_vnd_previewsystems_box,
        [Description("application_vnd_pvi_ptid1 - Princeton Video Image")]
        application_vnd_pvi_ptid1,
        [Description("application_pls_xml - Pronunciation Lexicon Specification")]
        application_pls_xml,
        [Description("application_vnd_pg_format - Proprietary P&G Standard Reporting System")]
        application_vnd_pg_format,
        [Description("application_vnd_pg_osasli - Proprietary P&G Standard Reporting System")]
        application_vnd_pg_osasli,
        [Description("text_prs_lines_tag - PRS Lines Tag")]
        text_prs_lines_tag,
        [Description("application_x_font_linux_psf - PSF Fonts")]
        application_x_font_linux_psf,
        [Description("application_vnd_publishare_delta_tree - PubliShare Objects")]
        application_vnd_publishare_delta_tree,
        [Description("application_vnd_pmi_widget - Qualcomm's Plaza Mobile Internet")]
        application_vnd_pmi_widget,
        [Description("application_vnd_quark_quarkxpress - QuarkXpress")]
        application_vnd_quark_quarkxpress,
        [Description("application_vnd_epson_esf - QUASS Stream Player")]
        application_vnd_epson_esf,
        [Description("application_vnd_epson_msf - QUASS Stream Player")]
        application_vnd_epson_msf,
        [Description("application_vnd_epson_ssf - QUASS Stream Player")]
        application_vnd_epson_ssf,
        [Description("application_vnd_epson_quickanime - QuickAnime Player")]
        application_vnd_epson_quickanime,
        [Description("application_vnd_intu_qfx - Quicken")]
        application_vnd_intu_qfx,
        [Description("video_quicktime - Quicktime Video")]
        video_quicktime,
        [Description("application_x_rar_compressed - RAR Archive")]
        application_x_rar_compressed,
        [Description("audio_x_pn_realaudio - Real Audio Sound")]
        audio_x_pn_realaudio,
        [Description("audio_x_pn_realaudio_plugin - Real Audio Sound")]
        audio_x_pn_realaudio_plugin,
        [Description("application_rsd_xml - Really Simple Discovery")]
        application_rsd_xml,
        [Description("application_vnd_rn_realmedia - RealMedia")]
        application_vnd_rn_realmedia,
        [Description("application_vnd_realvnc_bed - RealVNC")]
        application_vnd_realvnc_bed,
        [Description("application_vnd_recordare_musicxml - Recordare Applications")]
        application_vnd_recordare_musicxml,
        [Description("application_vnd_recordare_musicxml_xml - Recordare Applications")]
        application_vnd_recordare_musicxml_xml,
        [Description("application_relax_ng_compact_syntax - Relax NG Compact Syntax")]
        application_relax_ng_compact_syntax,
        [Description("application_vnd_data_vision_rdz - RemoteDocs R-Viewer")]
        application_vnd_data_vision_rdz,
        [Description("application_rdf_xml - Resource Description Framework")]
        application_rdf_xml,
        [Description("application_vnd_cloanto_rp9 - RetroPlatform Player")]
        application_vnd_cloanto_rp9,
        [Description("application_vnd_jisp - RhymBox")]
        application_vnd_jisp,
        [Description("application_rtf - Rich Text Format")]
        application_rtf,
        [Description("text_richtext - Rich Text Format (RTF)")]
        text_richtext,
        [Description("application_vnd_route66_link66_xml - ROUTE 66 Location Based Services")]
        application_vnd_route66_link66_xml,
        [Description("application_rss_xml - RSS - Really Simple Syndication")]
        application_rss_xml,
        [Description("application_shf_xml - S Hexdump Format")]
        application_shf_xml,
        [Description("application_vnd_sailingtracker_track - SailingTracker")]
        application_vnd_sailingtracker_track,
        [Description("image_svg_xml - Scalable Vector Graphics (SVG)")]
        image_svg_xml,
        [Description("application_vnd_sus_calendar - ScheduleUs")]
        application_vnd_sus_calendar,
        [Description("application_sru_xml - Search/Retrieve via URL Response Format")]
        application_sru_xml,
        [Description("application_set_payment_initiation - Secure Electronic Transaction - Payment")]
        application_set_payment_initiation,
        [Description("application_set_registration_initiation - Secure Electronic Transaction - Registration")]
        application_set_registration_initiation,
        [Description("application_vnd_sema - Secured eMail")]
        application_vnd_sema,
        [Description("application_vnd_semd - Secured eMail")]
        application_vnd_semd,
        [Description("application_vnd_semf - Secured eMail")]
        application_vnd_semf,
        [Description("application_vnd_seemail - SeeMail")]
        application_vnd_seemail,
        [Description("application_x_font_snf - Server Normal Format")]
        application_x_font_snf,
        [Description("application_scvp_vp_request - Server-Based Certificate Validation Protocol - Validation Policies - Request")]
        application_scvp_vp_request,
        [Description("application_scvp_vp_response - Server-Based Certificate Validation Protocol - Validation Policies - Response")]
        application_scvp_vp_response,
        [Description("application_scvp_cv_request - Server-Based Certificate Validation Protocol - Validation Request")]
        application_scvp_cv_request,
        [Description("application_scvp_cv_response - Server-Based Certificate Validation Protocol - Validation Response")]
        application_scvp_cv_response,
        [Description("application_sdp - Session Description Protocol")]
        application_sdp,
        [Description("text_x_setext - Setext")]
        text_x_setext,
        [Description("video_x_sgi_movie - SGI Movie")]
        video_x_sgi_movie,
        [Description("application_vnd_shana_informed_formdata - Shana Informed Filler")]
        application_vnd_shana_informed_formdata,
        [Description("application_vnd_shana_informed_formtemplate - Shana Informed Filler")]
        application_vnd_shana_informed_formtemplate,
        [Description("application_vnd_shana_informed_interchange - Shana Informed Filler")]
        application_vnd_shana_informed_interchange,
        [Description("application_vnd_shana_informed_package - Shana Informed Filler")]
        application_vnd_shana_informed_package,
        [Description("application_thraud_xml - Sharing Transaction Fraud Data")]
        application_thraud_xml,
        [Description("application_x_shar - Shell Archive")]
        application_x_shar,
        [Description("image_x_rgb - Silicon Graphics RGB Bitmap")]
        image_x_rgb,
        [Description("application_vnd_epson_salt - SimpleAnimeLite Player")]
        application_vnd_epson_salt,
        [Description("application_vnd_accpac_simply_aso - Simply Accounting")]
        application_vnd_accpac_simply_aso,
        [Description("application_vnd_accpac_simply_imp - Simply Accounting - Data Import")]
        application_vnd_accpac_simply_imp,
        [Description("application_vnd_simtech_mindmapper - SimTech MindMapper")]
        application_vnd_simtech_mindmapper,
        [Description("application_vnd_commonspace - Sixth Floor Media - CommonSpace")]
        application_vnd_commonspace,
        [Description("application_vnd_yamaha_smaf_audio - SMAF Audio")]
        application_vnd_yamaha_smaf_audio,
        [Description("application_vnd_smaf - SMAF File")]
        application_vnd_smaf,
        [Description("application_vnd_yamaha_smaf_phrase - SMAF Phrase")]
        application_vnd_yamaha_smaf_phrase,
        [Description("application_vnd_smart_teacher - SMART Technologies Apps")]
        application_vnd_smart_teacher,
        [Description("application_vnd_svd - SourceView Document")]
        application_vnd_svd,
        [Description("application_sparql_query - SPARQL - Query")]
        application_sparql_query,
        [Description("application_sparql_results_xml - SPARQL - Results")]
        application_sparql_results_xml,
        [Description("application_srgs - Speech Recognition Grammar Specification")]
        application_srgs,
        [Description("application_srgs_xml - Speech Recognition Grammar Specification - XML")]
        application_srgs_xml,
        [Description("application_ssml_xml - Speech Synthesis Markup Language")]
        application_ssml_xml,
        [Description("application_vnd_koan - SSEYO Koan Play File")]
        application_vnd_koan,
        [Description("text_sgml - Standard Generalized Markup Language (SGML)")]
        text_sgml,
        [Description("application_vnd_stardivision_calc - StarOffice - Calc")]
        application_vnd_stardivision_calc,
        [Description("application_vnd_stardivision_draw - StarOffice - Draw")]
        application_vnd_stardivision_draw,
        [Description("application_vnd_stardivision_impress - StarOffice - Impress")]
        application_vnd_stardivision_impress,
        [Description("application_vnd_stardivision_math - StarOffice - Math")]
        application_vnd_stardivision_math,
        [Description("application_vnd_stardivision_writer - StarOffice - Writer")]
        application_vnd_stardivision_writer,
        [Description("application_vnd_stardivision_writer_global - StarOffice - Writer (Global)")]
        application_vnd_stardivision_writer_global,
        [Description("application_vnd_stepmania_stepchart - StepMania")]
        application_vnd_stepmania_stepchart,
        [Description("application_x_stuffit - Stuffit Archive")]
        application_x_stuffit,
        [Description("application_x_stuffitx - Stuffit Archive")]
        application_x_stuffitx,
        [Description("application_vnd_solent_sdkm_xml - SudokuMagic")]
        application_vnd_solent_sdkm_xml,
        [Description("application_vnd_olpc_sugar - Sugar Linux Application Bundle")]
        application_vnd_olpc_sugar,
        [Description("audio_basic - Sun Audio - Au file format")]
        audio_basic,
        [Description("application_vnd_wqd - SundaHus WQ")]
        application_vnd_wqd,
        [Description("application_vnd_symbian_install - Symbian Install Package")]
        application_vnd_symbian_install,
        [Description("application_smil_xml - Synchronized Multimedia Integration Language")]
        application_smil_xml,
        [Description("application_vnd_syncml_xml - SyncML")]
        application_vnd_syncml_xml,
        [Description("application_vnd_syncml_dm_wbxml - SyncML - Device Management")]
        application_vnd_syncml_dm_wbxml,
        [Description("application_vnd_syncml_dm_xml - SyncML - Device Management")]
        application_vnd_syncml_dm_xml,
        [Description("application_x_sv4cpio - System V Release 4 CPIO Archive")]
        application_x_sv4cpio,
        [Description("application_x_sv4crc - System V Release 4 CPIO Checksum Data")]
        application_x_sv4crc,
        [Description("application_sbml_xml - Systems Biology Markup Language")]
        application_sbml_xml,
        [Description("text_tab_separated_values - Tab Seperated Values")]
        text_tab_separated_values,
        [Description("image_tiff - Tagged Image File Format")]
        image_tiff,
        [Description("application_vnd_tao_intent_module_archive - Tao Intent")]
        application_vnd_tao_intent_module_archive,
        [Description("application_x_tar - Tar File (Tape Archive)")]
        application_x_tar,
        [Description("application_x_tcl - Tcl Script")]
        application_x_tcl,
        [Description("application_x_tex - TeX")]
        application_x_tex,
        [Description("application_x_tex_tfm - TeX Font Metric")]
        application_x_tex_tfm,
        [Description("application_tei_xml - Text Encoding and Interchange")]
        application_tei_xml,
        [Description("text_plain - Text File")]
        text_plain,
        [Description("application_vnd_spotfire_dxp - TIBCO Spotfire")]
        application_vnd_spotfire_dxp,
        [Description("application_vnd_spotfire_sfs - TIBCO Spotfire")]
        application_vnd_spotfire_sfs,
        [Description("application_timestamped_data - Time Stamped Data Envelope")]
        application_timestamped_data,
        [Description("application_vnd_trid_tpt - TRI Systems Config")]
        application_vnd_trid_tpt,
        [Description("application_vnd_triscape_mxs - Triscape Map Explorer")]
        application_vnd_triscape_mxs,
        [Description("text_troff - troff")]
        text_troff,
        [Description("application_vnd_trueapp - True BASIC")]
        application_vnd_trueapp,
        [Description("application_x_font_ttf - TrueType Font")]
        application_x_font_ttf,
        [Description("text_turtle - Turtle (Terse RDF Triple Language)")]
        text_turtle,
        [Description("application_vnd_umajin - UMAJIN")]
        application_vnd_umajin,
        [Description("application_vnd_uoml_xml - Unique Object Markup Language")]
        application_vnd_uoml_xml,
        [Description("application_vnd_unity - Unity 3d")]
        application_vnd_unity,
        [Description("application_vnd_ufdl - Universal Forms Description Language")]
        application_vnd_ufdl,
        [Description("text_uri_list - URI Resolution Services")]
        text_uri_list,
        [Description("application_vnd_uiq_theme - User Interface Quartz - Theme (Symbian)")]
        application_vnd_uiq_theme,
        [Description("application_x_ustar - Ustar (Uniform Standard Tape Archive)")]
        application_x_ustar,
        [Description("text_x_uuencode - UUEncode")]
        text_x_uuencode,
        [Description("text_x_vcalendar - vCalendar")]
        text_x_vcalendar,
        [Description("text_x_vcard - vCard")]
        text_x_vcard,
        [Description("application_x_cdlink - Video CD")]
        application_x_cdlink,
        [Description("application_vnd_vsf - Viewport+")]
        application_vnd_vsf,
        [Description("model_vrml - Virtual Reality Modeling Language")]
        model_vrml,
        [Description("application_vnd_vcx - VirtualCatalog")]
        application_vnd_vcx,
        [Description("model_vnd_mts - Virtue MTS")]
        model_vnd_mts,
        [Description("model_vnd_vtu - Virtue VTU")]
        model_vnd_vtu,
        [Description("application_vnd_visionary - Visionary")]
        application_vnd_visionary,
        [Description("video_vnd_vivo - Vivo")]
        video_vnd_vivo,
        [Description("application_ccxml_xml, - Voice Browser Call Control")]
        application_ccxml_xml,
        [Description("application_voicexml_xml - VoiceXML")]
        application_voicexml_xml,
        [Description("application_x_wais_source - WAIS Source")]
        application_x_wais_source,
        [Description("application_vnd_wap_wbxml - WAP Binary XML (WBXML)")]
        application_vnd_wap_wbxml,
        [Description("image_vnd_wap_wbmp - WAP Bitamp (WBMP)")]
        image_vnd_wap_wbmp,
        [Description("audio_x_wav - Waveform Audio File Format (WAV)")]
        audio_x_wav,
        [Description("application_davmount_xml - Web Distributed Authoring and Versioning")]
        application_davmount_xml,
        [Description("application_x_font_woff - Web Open Font Format")]
        application_x_font_woff,
        [Description("application_wspolicy_xml - Web Services Policy")]
        application_wspolicy_xml,
        [Description("image_webp - WebP Image")]
        image_webp,
        [Description("application_vnd_webturbo - WebTurbo")]
        application_vnd_webturbo,
        [Description("application_widget - Widget Packaging and XML Configuration")]
        application_widget,
        [Description("application_winhlp - WinHelp")]
        application_winhlp,
        [Description("text_vnd_wap_wml - Wireless Markup Language (WML)")]
        text_vnd_wap_wml,
        [Description("text_vnd_wap_wmlscript - Wireless Markup Language Script (WMLScript)")]
        text_vnd_wap_wmlscript,
        [Description("application_vnd_wap_wmlscriptc - WMLScript")]
        application_vnd_wap_wmlscriptc,
        [Description("application_vnd_wordperfect - Wordperfect")]
        application_vnd_wordperfect,
        [Description("application_vnd_wt_stf - Worldtalk")]
        application_vnd_wt_stf,
        [Description("application_wsdl_xml - WSDL - Web Services Description Language")]
        application_wsdl_xml,
        [Description("image_x_xbitmap - X BitMap")]
        image_x_xbitmap,
        [Description("image_x_xpixmap - X PixMap")]
        image_x_xpixmap,
        [Description("image_x_xwindowdump - X Window Dump")]
        image_x_xwindowdump,
        [Description("application_x_x509_ca_cert - X.509 Certificate")]
        application_x_x509_ca_cert,
        [Description("application_x_xfig - Xfig")]
        application_x_xfig,
        [Description("application_xhtml_xml - XHTML - The Extensible HyperText Markup Language")]
        application_xhtml_xml,
        [Description("application_xml - XML - Extensible Markup Language")]
        application_xml,
        [Description("application_xcap_diff_xml - XML Configuration Access Protocol - XCAP Diff")]
        application_xcap_diff_xml,
        [Description("application_xenc_xml - XML Encryption Syntax and Processing")]
        application_xenc_xml,
        [Description("application_patch_ops_error_xml - XML Patch Framework")]
        application_patch_ops_error_xml,
        [Description("application_resource_lists_xml - XML Resource Lists")]
        application_resource_lists_xml,
        [Description("application_rls_services_xml - XML Resource Lists")]
        application_rls_services_xml,
        [Description("application_resource_lists_diff_xml - XML Resource Lists Diff")]
        application_resource_lists_diff_xml,
        [Description("application_xslt_xml - XML Transformations")]
        application_xslt_xml,
        [Description("application_xop_xml - XML-Binary Optimized Packaging")]
        application_xop_xml,
        [Description("application_x_xpinstall - XPInstall - Mozilla")]
        application_x_xpinstall,
        [Description("application_xspf_xml - XSPF - XML Shareable Playlist Format")]
        application_xspf_xml,
        [Description("application_vnd_mozilla_xul_xml - XUL - XML User Interface Language")]
        application_vnd_mozilla_xul_xml,
        [Description("chemical_x_xyz - XYZ File Format")]
        chemical_x_xyz,
        [Description("text_yaml - YAML Ain't Markup Language / Yet Another Markup Language")]
        text_yaml,
        [Description("application_yang - YANG Data Modeling Language")]
        application_yang,
        [Description("application_yin_xml - YIN (YANG - XML)")]
        application_yin_xml,
        [Description("application_vnd_zul - Z.U.L. Geometry")]
        application_vnd_zul,
        [Description("application_zip - Zip Archive")]
        application_zip,
        [Description("application_vnd_handheld_entertainment_xml - ZVUE Media Manager")]
        application_vnd_handheld_entertainment_xml,
        [Description("application_vnd_zzazz_deck_xml - Zzazz Deck")]
        application_vnd_zzazz_deck_xml,
    }
}

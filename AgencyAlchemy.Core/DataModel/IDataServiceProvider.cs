using System;
namespace AgencyAlchemy.Core.DataModel
{
    interface IDataServiceProvider
    {
        System.Data.Objects.ObjectResult<account_fetch_Result> account_fetch(int? aGENCY, int? lOGIN);
        System.Data.Objects.ObjectResult<int?> account_update(int? aGENCY, int? lOGIN, string fIRSTNAME, string lASTNAME, string aDDRESS, string cITY, string sTATE, string pOSTAL, string sKYPE, string pASSWORD, string pHONE);
        System.Data.Objects.ObjectResult<acp_list_Result> acp_list(int? aGENCY, int? cLIENT, int? aUTHUSER);
        System.Data.Entity.DbSet<agency> agencies { get; set; }
        System.Data.Entity.DbSet<agency_applicants> agency_applicants { get; set; }
        System.Data.Objects.ObjectResult<int?> agency_approve(int? aGENCYPK);
        System.Data.Objects.ObjectResult<int?> agency_create(string aGENCY, string uRL, string tAXID, string aDMIN_FIRSTNAME, string aDMIN_LASTNAME, string aDMIN_EMAIL);
        int agency_domain_create(string name, string url, int? agency_id, int? authuser);
        System.Data.Objects.ObjectResult<agency_fetch_Result> agency_fetch(int? iD);
        System.Data.Objects.ObjectResult<agency_fetch_by_domain_Result> agency_fetch_by_domain(string dOMAIN);
        System.Data.Objects.ObjectResult<agency_fetch_clientmanager_Result> agency_fetch_clientmanager(int? aGENCY, int? cLIENT);
        System.Data.Objects.ObjectResult<agency_fetch_talentmanager_Result> agency_fetch_talentmanager(int? aGENCY, int? tALENT);
        System.Data.Objects.ObjectResult<int?> agency_home_edit(int? aGENCY, int? lOGIN, string tITLE, string tEXT, string yOUTUBE);
        System.Data.Objects.ObjectResult<agency_list_Result> agency_list(int? aUTHUSER);
        System.Data.Objects.ObjectResult<agency_list_clientmanagers_Result> agency_list_clientmanagers(int? aGENCY);
        System.Data.Objects.ObjectResult<agency_list_people_Result> agency_list_people(int? aGENCY);
        System.Data.Objects.ObjectResult<agency_list_talentmanagers_Result> agency_list_talentmanagers(int? aGENCY);
        System.Data.Entity.DbSet<agency_metrics_categories> agency_metrics_categories { get; set; }
        System.Data.Entity.DbSet<agency_people> agency_people { get; set; }
        int agency_people_rate_delete(int? aGENCYRATEID);
        System.Data.Objects.ObjectResult<agency_people_rate_list_Result> agency_people_rate_list(int? aGENCY, int? tALENT);
        System.Data.Entity.DbSet<agency_people_rates> agency_people_rates { get; set; }
        System.Data.Entity.DbSet<agency_people_roles> agency_people_roles { get; set; }
        System.Data.Objects.ObjectResult<int?> agency_settings(int? aGENCY, int? lOGIN, string nAME, string aNALYTICS, string fOOTER, string cSS, int? sKIN_TALENT_PRIVATE, int? sKIN_TALENT_PUBLIC, int? sKIN_COMPSHEET, string fACEBOOK, string tWITTER, string yOUTUBE, string lINKEDIN, string gPLUS, string lOCATION_NAME, string lOCATION_URL, decimal? lOCATION_LAT, decimal? lOCATION_LONG, string pHONE, string eMAIL, int? pHOTOREQ, string pHOTO1, string pHOTO2, string pHOTO3, string pHOTO4, string pHOTO5, string mAIL_WELCOMEAPPLICANT, string tEMPLATE_EVENT, string tEMPLATE_SLOT_PUBLIC, string tEMPLATE_SLOT_CLIENT, string tEMPLATE_SLOT_TALENT);
        System.Data.Objects.ObjectResult<int?> agency_settings_media(int? aGENCY, string tYPE, bool? vALUE);
        System.Data.Objects.ObjectResult<agency_talent_list_Result> agency_talent_list(int? aGENCY, int? fEATURED, int? aCTIVE, int? cOLLECTION);
        System.Data.Objects.ObjectResult<agency_talent_list_qs_Result> agency_talent_list_qs(int? aGENCY, int? fEATURED, int? aCTIVE, int? cOLLECTION);
        int agencyjoin_create(Guid? gUID, string fIRSTNAME, string lASTNAME, string eMAIL, string pASSWORD, string fACEBOOK);
        System.Data.Objects.ObjectResult<int?> book_now(int? lOGIN, int? aGENCY, int? sLOT, int? eVENT, int? tALENT);
        System.Data.Objects.ObjectResult<book_setstatus_Result> book_setstatus(int? aGENCY, int? lOGIN, int? iD, int? sTATUS);
        System.Data.Objects.ObjectResult<book_slot_fetch_Result> book_slot_fetch(int? aGENCY, int? sLOT);
        System.Data.Objects.ObjectResult<book_talent_list_Result> book_talent_list(int? aGENCY, int? eVENT, int? sLOT);
        System.Data.Objects.ObjectResult<book_talent_list_compsheet_Result> book_talent_list_compsheet(int? aGENCY, int? eVENT, int? sLOT);
        System.Data.Objects.ObjectResult<book_talent_list_old_Result> book_talent_list_old(int? aGENCY, int? eVENT, int? sLOT);
        System.Data.Objects.ObjectResult<int?> book_unbook(int? aGENCY, int? lOGIN, int? iD);
        System.Data.Objects.ObjectResult<booknow_current_status_Result> booknow_current_status(int? sLOT, int? tALENT);
        System.Data.Objects.ObjectResult<booknow_info_Result> booknow_info(int? sLOT, int? tALENT, int? aGENCY);
        System.Data.Objects.ObjectResult<int?> booknow_update_rate(int? sLOT, int? tALENT, int? rATETYPE, decimal? rATE);
        System.Data.Objects.ObjectResult<booknow_update_status_Result> booknow_update_status(int? sLOT, int? tALENT, string tYPE, int? aUTHUSER);
        System.Data.Entity.DbSet<client_dispositions> client_dispositions { get; set; }
        System.Data.Objects.ObjectResult<client_list_events_Result> client_list_events(int? cLIENT, int? aGENCY);
        System.Data.Entity.DbSet<client> clients { get; set; }
        System.Data.Objects.ObjectResult<clients_add_Result> clients_add(int? lOGIN, int? aGENCY, string nAME, string aDDRESS, string cITY, string sTATE, string zIPCODE, string tAGS, string nOTES, bool? aCTIVE, int? mANAGER);
        System.Data.Objects.ObjectResult<int?> clients_approve(int? lOGIN, int? aGENCY, int? iD);
        System.Data.Objects.ObjectResult<int?> clients_delete(int? lOGIN, int? aGENCY, int? iD);
        int clients_deletecontact(int? lOGIN, int? aGENCY, int? iD);
        System.Data.Objects.ObjectResult<int?> clients_deny(int? lOGIN, int? aGENCY, int? iD);
        System.Data.Objects.ObjectResult<clients_directory_Result> clients_directory(int? lOGIN, int? aGENCY);
        System.Data.Objects.ObjectResult<clients_edit_Result> clients_edit(int? lOGIN, int? aGENCY, string nAME, string aDDRESS, string wEBSITE, string cITY, string sTATE, string zIPCODE, int? iD, bool? aCTIVE, string tAGS, string nOTES, int? mANAGER);
        System.Data.Objects.ObjectResult<clients_editcontact_Result> clients_editcontact(int? lOGIN, int? aGENCY, int? iD, string fIRSTNAME, string lASTNAME, string pHONE, string fAX, string cELL, string hOME, string sKYPE, string eMAIL, string tITLE, string nOTES);
        System.Data.Objects.ObjectResult<clients_fetch_Result> clients_fetch(int? aGENCY, int? cLIENT, int? aUTHUSER);
        System.Data.Objects.ObjectResult<int?> clients_join_agency(int? aGENCY, string nAME, string aDDRESS, string cITY, string sTATE, string zIPCODE, string fIRSTNAME, string lASTNAME, string eMAIL);
        System.Data.Objects.ObjectResult<clients_list_Result> clients_list(int? aGENCY);
        System.Data.Objects.ObjectResult<int?> collection_addtalent(int? aGENCY, int? tALENT, int? eXISTING, string nEW, int? aUTHUSER, bool? oFFICIAL, bool? oRGSHARED);
        System.Data.Objects.ObjectResult<int?> collection_delete(int? aGENCY, int? aUTHUSER, int? cOLLECTION);
        System.Data.Objects.ObjectResult<int?> collection_edit(int? aUTHUSER, int? cOLLECTION, string nAME, bool? oRGSHARED, bool? oFFICIAL);
        System.Data.Objects.ObjectResult<collection_fetch_Result> collection_fetch(int? cOLLECTION, int? aGENCY);
        System.Data.Objects.ObjectResult<collection_list_Result> collection_list(int? lOGIN, int? aGENCY);
        System.Data.Objects.ObjectResult<collection_list_talent_Result> collection_list_talent(int? aUTHUSER, int? aGENCY, int? tALENT);
        System.Data.Objects.ObjectResult<int?> collection_removetalent(int? aGENCY, int? tALENT, int? cOLLECTION, int? aUTHUSER);
        System.Data.Entity.DbSet<collection> collections { get; set; }
        System.Data.Entity.DbSet<collectiontalent> collectiontalents { get; set; }
        System.Data.Objects.ObjectResult<compsheet_fetch_Result> compsheet_fetch(string gUID, int? aGENCY);
        System.Data.Objects.ObjectResult<compsheet_metrics_Result> compsheet_metrics(int? aGENCY, int? tALENT);
        System.Data.Entity.DbSet<contact_logs> contact_logs { get; set; }
        System.Data.Objects.ObjectResult<contactlog_contacts_Result> contactlog_contacts(int? aGENCY);
        System.Data.Objects.ObjectResult<contactlog_create_Result> contactlog_create(int? aGENCY, int? lOGIN, string tEXT, bool? iS_PRIVATE, int? nOTE_TYPE, int? tALENT_FK, int? cLIENT_FK, int? cONTACT_FK, DateTime? dATE);
        System.Data.Objects.ObjectResult<int?> contactlog_delete(int? aGENCY, int? lOGIN, int? iD);
        System.Data.Objects.ObjectResult<contactlog_fetch_Result> contactlog_fetch(int? aGENCY, int? lOGIN, int? iD);
        System.Data.Objects.ObjectResult<contactlog_list_Result> contactlog_list(int? aGENCY, int? lOGIN, int? cLIENT, int? tALENT);
        System.Data.Entity.DbSet<contract> contracts { get; set; }
        System.Data.Objects.ObjectResult<dashboard_agencyadmin_Result> dashboard_agencyadmin(int? aGENCY, int? lOGIN);
        System.Data.Objects.ObjectResult<dashboard_agencyadmin_talent_todo_Result> dashboard_agencyadmin_talent_todo(int? aGENCY);
        System.Data.Objects.ObjectResult<dashboard_talent_slots_Result> dashboard_talent_slots(int? aGENCY, int? tALENT);
        System.Data.Objects.ObjectResult<string> document_delete(string iD);
        System.Data.Objects.ObjectResult<documents_list_Result> documents_list(int? aGENCY, int? eVENT, int? tALENT, int? cLIENT);
        System.Data.Objects.ObjectResult<documents_list_client_Result> documents_list_client(int? aGENCY, int? cLIENT);
        System.Data.Objects.ObjectResult<documents_list_event_Result> documents_list_event(int? aGENCY, int? eVENT);
        System.Data.Objects.ObjectResult<documents_list_talent_Result> documents_list_talent(int? aGENCY, int? tALENT);
        System.Data.Entity.DbSet<domain> domains { get; set; }
        System.Data.Objects.ObjectResult<emailupload_checkpermissions_Result> emailupload_checkpermissions(string eMAIL, string tYPE, int? iD);
        System.Data.Entity.DbSet<event_dates> event_dates { get; set; }
        System.Data.Entity.DbSet<event_people> event_people { get; set; }
        System.Data.Entity.DbSet<event_slotavailable> event_slotavailable { get; set; }
        System.Data.Entity.DbSet<event_slotdates> event_slotdates { get; set; }
        System.Data.Entity.DbSet<event_slots> event_slots { get; set; }
        System.Data.Entity.DbSet<event_statuses> event_statuses { get; set; }
        int event_statusupdate(int? eVENT);
        System.Data.Objects.ObjectResult<int?> event_statusupdate_force(int? aGENCY, int? lOGIN, int? eVENT, int? sTATUS);
        System.Data.Objects.ObjectResult<eventdates_create_Result> eventdates_create(int? eVENT, int? lOGIN, int? aGENCY, DateTime? sTART, DateTime? eND, bool? aLLDAY, string dESCRIPTION);
        int eventdates_delete(int? iD, int? lOGIN, int? aGENCY);
        System.Data.Objects.ObjectResult<eventdates_edit_Result> eventdates_edit(int? iD, int? lOGIN, int? aGENCY, DateTime? sTART, DateTime? eND, bool? aLLDAY, string dESCRIPTION);
        System.Data.Objects.ObjectResult<eventdates_fetch_Result> eventdates_fetch(int? iD);
        System.Data.Objects.ObjectResult<eventdates_list_Result> eventdates_list(int? iD);
        System.Data.Entity.DbSet<@event> events { get; set; }
        System.Data.Objects.ObjectResult<int?> events_approve(int? aGENCY, int? lOGIN, int? iD);
        System.Data.Objects.ObjectResult<int?> events_create(int? aGENCY, int? lOGIN, string tITLE, string sUMMARY, string wEBSITE, int? cLIENT, string tAGS, bool? fREELANCERS);
        System.Data.Objects.ObjectResult<events_delete_Result> events_delete(int? aGENCY, int? lOGIN, int? iD);
        System.Data.Objects.ObjectResult<events_directory_Result> events_directory(int? lOGIN, int? aGENCY);
        System.Data.Objects.ObjectResult<int?> events_edit(int? aGENCY, int? lOGIN, int? iD, string tITLE, string sUMMARY, string wEBSITE, int? cLIENT, string tAGS, bool? fREELANCERS);
        System.Data.Objects.ObjectResult<events_fetch_Result> events_fetch(int? iD, int? aGENCY);
        System.Data.Objects.ObjectResult<events_list_Result> events_list(DateTime? sTART, DateTime? eND, int? aGENCY, int? cLIENT, int? tALENT);
        System.Data.Objects.ObjectResult<int?> events_slots_add(int? aGENCY, int? lOGIN, int? eVENT, int? qUANTITY, string nAME, string dESCRIPTION, string dESCRIPTION_TALENT, string dESCRIPTION_CLIENT, string mETRICS, string lOCATION_NAME, string lOCATION_URL, decimal? lOCATION_LAT, decimal? lOCATION_LONG);
        System.Data.Objects.ObjectResult<int?> events_slots_addtalent(int? aGENCY, int? lOGIN, int? sLOT, int? tALENT, bool? aPPROVEDAGENCY, bool? aPPROVEDCLIENT, bool? aPPROVEDTALENT);
        System.Data.Objects.ObjectResult<int?> events_slots_delete(int? aGENCY, int? lOGIN, int? iD);
        System.Data.Objects.ObjectResult<int?> events_slots_edit(int? aGENCY, int? lOGIN, int? iD, int? qUANTITY, string nAME, string dESCRIPTION, string dESCRIPTION_TALENT, string dESCRIPTION_CLIENT, string mETRICS, string lOCATION_NAME, string lOCATION_URL, decimal? lOCATION_LAT, decimal? lOCATION_LONG);
        System.Data.Objects.ObjectResult<events_slots_fetch_Result> events_slots_fetch(int? aGENCY, int? iD);
        System.Data.Objects.ObjectResult<int?> events_slots_ignore(int? aGENCY, int? lOGIN, int? iD, bool? iS_ADMIN, bool? iS_CLIENT, bool? iS_TALENT);
        System.Data.Objects.ObjectResult<events_slots_list_Result> events_slots_list(int? aGENCY, int? eVENT, int? lOGIN);
        System.Data.Objects.ObjectResult<events_slots_metrics_Result> events_slots_metrics(int? aGENCY, int? sLOT);
        System.Data.Objects.ObjectResult<events_talent_assign_Result> events_talent_assign(int? eVENT, int? aGENCY, int? lOGIN, int? tALENT, bool? bYPASSTALENT, bool? bYPASSCLIENT);
        System.Data.Objects.ObjectResult<events_talent_list_Result> events_talent_list(int? eVENT, int? aGENCY);
        int events_talent_remove(int? eVENT, int? aGENCY, int? lOGIN, int? tALENT);
        System.Data.Objects.ObjectResult<int?> eventslotavailable_set(int? aGENCY, int? lOGIN, int? pERSON, int? sLOT, bool? vALUE);
        System.Data.Objects.ObjectResult<eventstatus_list_Result> eventstatus_list();
        System.Data.Entity.DbSet<flag> flags { get; set; }
        System.Data.Objects.ObjectResult<flags_fetch_Result> flags_fetch(int? lOGIN, bool? dEFAULT_AUTHENTICATED, bool? dEFAULT_TALENT, bool? dEFAULT_CLIENT, bool? dEFAULT_AGENCYADMIN);
        System.Data.Objects.ObjectResult<flags_list_Result> flags_list(int? pERSON, string lAYER);
        System.Data.Objects.ObjectResult<flags_list_agency_Result> flags_list_agency(int? pERSON, int? aGENCY);
        System.Data.Objects.ObjectResult<flags_list_client_Result> flags_list_client(int? pERSON, int? cLIENT);
        System.Data.Objects.ObjectResult<int?> isdupe_agencyurl(string sTRING);
        System.Data.Entity.DbSet<location> locations { get; set; }
        int log_insert(int? pEOPLEID, string lOGTEXT);
        System.Data.Objects.ObjectResult<login_authorize_Result> login_authorize(string pROVIDER, string uID, string cODE, int? aGENCY);
        System.Data.Objects.ObjectResult<login_fetch_Result> login_fetch(int? lOGIN);
        System.Data.Objects.ObjectResult<int?> login_setflag(int? lOGIN, int? pERSON, int? cLIENT, int? aGENCY, int? fLAGID, bool? vALUE);
        int login_setflag_byname(int? pERSON, int? aGENCY, string fLAG, bool? vALUE);
        System.Data.Entity.DbSet<log> logs { get; set; }
        System.Data.Objects.ObjectResult<mailer_sendall_Result> mailer_sendall();
        System.Data.Entity.DbSet<mailer> mailers { get; set; }
        System.Data.Entity.DbSet<medium> media { get; set; }
        System.Data.Objects.ObjectResult<media_add_Result> media_add(int? aUTHUSER, string tYPE, int? pERSON, int? aGENCY, int? eVENT, int? cLIENT, string tITLE, string uRL, string tHUMB, bool? iS_LOCAL, int? sLOT, bool? vISIBLE_BOOKED, bool? vISIBLE_UNBOOKED, bool? vISIBLE_CLIENT);
        System.Data.Objects.ObjectResult<media_delete_Result> media_delete(string pATH, int? lOGIN);
        System.Data.Objects.ObjectResult<media_fetch_Result> media_fetch(int? lOGIN, string mEDIA);
        System.Data.Objects.ObjectResult<media_list_Result> media_list(int? aGENCY, int? tALENT, int? cLIENT);
        System.Data.Entity.DbSet<mediacategory> mediacategories { get; set; }
        System.Data.Objects.ObjectResult<mediacategories_list_Result> mediacategories_list();
        System.Data.Objects.ObjectResult<metriccategories_list_Result> metriccategories_list(int? aGENCY);
        System.Data.Entity.DbSet<metric> metrics { get; set; }
        System.Data.Entity.DbSet<metrics_categories> metrics_categories { get; set; }
        System.Data.Entity.DbSet<metrics_custom> metrics_custom { get; set; }
        System.Data.Entity.DbSet<note> notes { get; set; }
        System.Data.Objects.ObjectResult<int?> page_customize(int? aGENCY, int? aUTHUSER, string pATH, string tITLE, string sUBTITLE, string dESCRIPTION, string mETATITLE, string mETAKEYWORDS, string mETADESCRIPTION);
        System.Data.Objects.ObjectResult<page_fetch_Result> page_fetch(int? aGENCY, string pATH);
        System.Data.Entity.DbSet<page_settings> page_settings { get; set; }
        System.Data.Entity.DbSet<page> pages { get; set; }
        System.Data.Objects.ObjectResult<int?> pages_create(int? aGENCY, string uRL, string nAVPARENT, int? pARENTORDINAL, string nAVTEXT, bool? nAVDISPLAY, int? oRDINAL, int? lOGIN);
        System.Data.Objects.ObjectResult<int?> pages_delete(int? iD, int? aGENCY, int? lOGIN);
        System.Data.Objects.ObjectResult<int?> pages_edit(int? iD, int? aGENCY, string uRL, string nAVPARENT, string nAVTEXT, bool? nAVDISPLAY, int? oRDINAL, int? lOGIN);
        System.Data.Objects.ObjectResult<pages_list_Result> pages_list(int? aGENCY);
        System.Data.Entity.DbSet<payment> payments { get; set; }
        System.Data.Entity.DbSet<person> people { get; set; }
        System.Data.Objects.ObjectResult<int?> people_addlogin(int? aGENCY, int? cLIENT, int? tALENT, string pASSWORD);
        System.Data.Objects.ObjectResult<people_agencies_list_Result> people_agencies_list(int? iD);
        System.Data.Objects.ObjectResult<people_clients_list_Result> people_clients_list(int? iD);
        System.Data.Objects.ObjectResult<people_create_Result> people_create(int? aGENCY, int? cLIENT, string fIRSTNAME, string lASTNAME, string eMAIL, bool? iS_ADMIN, bool? iS_CLIENT, bool? iS_TALENT, bool? iS_CLIENTMANAGER, bool? iS_TALENTMANAGER, bool? sENDINVITE, string pHONE, string cELL, string hOME, string tITLE, string fAX, string sKYPE, string nOTES, string fACEBOOK, string tWITTER, string gOOGLE, string oPENID, string aOL, int? jOINSTEP, string pASSWORD, int? mANAGER, bool? eXCLUSIVE);
        System.Data.Objects.ObjectResult<int?> people_dupecheck(string eMAIL);
        System.Data.Objects.ObjectResult<people_fetch_by_pk_Result> people_fetch_by_pk(int? iD, int? aGENCY);
        System.Data.Objects.ObjectResult<people_fetch_by_unique_Result> people_fetch_by_unique(string gUID);
        System.Data.Objects.ObjectResult<byte?> people_get_joinstep(int? iD);
        int people_join(string fIRSTNAME, string lASTNAME, string eMAIL, string pHONE, string tITLE, string fAX, string sKYPE, string nOTES, string fACEBOOK, string tWITTER, string gOOGLE, string oPENID, string aOL, int? jOINSTEP);
        System.Data.Objects.ObjectResult<int?> people_join_update(int? iD, string fIRSTNAME, string lASTNAME, string sTAGENAME, string aDDRESS, string aDDRESS2, string cITY, string sTATE, string pOSTAL, string bIRTHDATE);
        System.Data.Objects.ObjectResult<people_list_Result> people_list();
        System.Data.Entity.DbSet<people_locations> people_locations { get; set; }
        System.Data.Objects.ObjectResult<people_login_Result> people_login(int? aGENCY, string eMAIL, string pASSWORD, bool? rEMEMBER, bool? iMPERSONATE);
        System.Data.Objects.ObjectResult<people_login_cookie_Result> people_login_cookie(int? aGENCY, string rEMEMBER);
        System.Data.Objects.ObjectResult<people_login_old_Result> people_login_old(string pROVIDER, string uID, int? aGENCY);
        System.Data.Entity.DbSet<people_metrics> people_metrics { get; set; }
        System.Data.Entity.DbSet<people_rating> people_rating { get; set; }
        System.Data.Objects.ObjectResult<int?> people_resetpassword(int? aGENCY, string eMAIL);
        int people_set_joinstep(int? iD, int? jOINSTEP);
        int person_add2agency(int? pERSON, int? aGENCY, bool? iS_ADMIN, bool? iS_SUPERADMIN);
        System.Data.Entity.DbSet<position_statuses> position_statuses { get; set; }
        System.Data.Objects.ObjectResult<int?> position_statusupdate_force(int? aGENCY, int? lOGIN, int? pOSITION, int? sTATUS);
        System.Data.Objects.ObjectResult<positionstatus_list_Result> positionstatus_list();
        System.Data.Entity.DbSet<private_notes> private_notes { get; set; }
        System.Data.Objects.ObjectResult<privatenote_add_Result> privatenote_add(int? aUTHUSER, int? tALENT, string nOTE, bool? sHARED);
        System.Data.Objects.ObjectResult<int?> privatenote_delete(int? aUTHUSER, int? iD);
        System.Data.Objects.ObjectResult<privatenote_edit_Result> privatenote_edit(int? aUTHUSER, int? iD, string nOTE, bool? sHARED);
        System.Data.Objects.ObjectResult<privatenote_list_Result> privatenote_list(int? aGENCY, int? aUTHUSER, int? tALENT);
        System.Data.Objects.ObjectResult<quicksearch_list_Result> quicksearch_list(int? aGENCY);
        System.Data.Objects.ObjectResult<rate_type_list_Result> rate_type_list(int? aGENCY);
        System.Data.Entity.DbSet<rate_types> rate_types { get; set; }
        int ratetype_create(int? aGENCY, string rATETYPE);
        int ratetype_delete(int? tYPEID);
        int ratetype_edit(int? tYPEID, string rATETYPE);
        System.Data.Entity.DbSet<role> roles { get; set; }
        int scheduled_daily();
        System.Data.Objects.ObjectResult<search_talent_slots_Result> search_talent_slots(int? aGENCY, int? sLOT, string sTRING);
        System.Data.Objects.ObjectResult<int?> setup_talent_biography(int? lOGIN, int? aGENCY, int? iD, string bIRTHDATE, string pHONE, string lOCATION_NAME, string lOCATION_URL, decimal? lOCATION_LAT, decimal? lOCATION_LONG, string bIOGRAPHY);
        System.Data.Objects.ObjectResult<int?> setup_talent_experience(int? lOGIN, int? aGENCY, int? iD, string eXPERIENCE);
        System.Data.Objects.ObjectResult<int?> setup_talent_metriccount(int? iD);
        System.Data.Objects.ObjectResult<bool?> skillstree_agency_toggle(int? cATEGORY, int? aGENCY, int? lOGIN);
        System.Data.Objects.ObjectResult<int?> skillstree_agency_toggle_compsheet(int? cATEGORY, int? aGENCY, int? lOGIN);
        System.Data.Objects.ObjectResult<int?> skillstree_agency_toggle_quicksearch(int? cATEGORY, int? aGENCY, int? lOGIN);
        System.Data.Objects.ObjectResult<skillstree_category_add_Result> skillstree_category_add(int? pARENT, int? aUTHUSER, string nAME, bool? cONTAINS);
        System.Data.Objects.ObjectResult<int?> skillstree_category_delete(int? iD, int? aUTHUSER);
        System.Data.Objects.ObjectResult<skillstree_category_edit_Result> skillstree_category_edit(int? iD, int? aUTHUSER, string nAME, bool? cONTAINS, bool? mULTIPLE, string fULLNAME);
        System.Data.Objects.ObjectResult<skillstree_category_fetch_Result> skillstree_category_fetch(int? iD, int? aUTHUSER, int? aGENCY, int? tALENT);
        System.Data.Objects.ObjectResult<skillstree_fetch_Result> skillstree_fetch(int? iD, int? aUTHUSER, int? aGENCY, int? tALENT);
        System.Data.Objects.ObjectResult<skillstree_listall_Result> skillstree_listall(int? aGENCY, int? sLOT);
        System.Data.Objects.ObjectResult<skillstree_metric_add_Result> skillstree_metric_add(int? pARENT, int? aUTHUSER, string nAME);
        System.Data.Objects.ObjectResult<int?> skillstree_metric_delete(int? iD, int? aUTHUSER);
        System.Data.Objects.ObjectResult<int?> skillstree_metric_down(int? iD, int? aUTHUSER);
        System.Data.Objects.ObjectResult<skillstree_metric_edit_Result> skillstree_metric_edit(int? iD, int? aUTHUSER, string nAME);
        System.Data.Objects.ObjectResult<skillstree_metric_fetch_Result> skillstree_metric_fetch(int? iD);
        System.Data.Objects.ObjectResult<int?> skillstree_metric_up(int? iD, int? aUTHUSER);
        System.Data.Objects.ObjectResult<int?> skillstree_set(int? tALENT, int? aGENCY, int? mETRIC, int? aUTHUSER, int? cATEGORY);
        System.Data.Objects.ObjectResult<int?> skillstree_set_multiple(int? tALENT, int? aGENCY, int? mETRIC, int? aUTHUSER, int? cATEGORY, bool? vALUE);
        int skilltree_tools_convert_to_metrics(int? iD);
        System.Data.Entity.DbSet<skin> skins { get; set; }
        System.Data.Objects.ObjectResult<skins_list_Result> skins_list(int? aGENCY);
        System.Data.Objects.ObjectResult<slotdate_add_Result> slotdate_add(int? eVENT, int? sLOT, DateTime? dATE, TimeSpan? sTART, TimeSpan? eND);
        int slotdate_delete(int? iD);
        System.Data.Objects.ObjectResult<slotdate_edit_Result> slotdate_edit(int? iD, DateTime? dATE, TimeSpan? sTART, TimeSpan? eND);
        System.Data.Objects.ObjectResult<slotdate_list_Result> slotdate_list(int? eVENT);
        System.Data.Objects.ObjectResult<slots_fetch_Result> slots_fetch(int? aGENCY, int? iD);
        System.Data.Objects.ObjectResult<slots_list_Result> slots_list(int? aGENCY, DateTime? sTARTDATE, DateTime? eNDDATE, int? sTATUS);
        System.Data.Objects.ObjectResult<slots_talent_available_Result> slots_talent_available(int? aGENCY, int? sLOT);
        System.Data.Objects.ObjectResult<slots_talent_booked_Result> slots_talent_booked(int? aGENCY, int? sLOT);
        System.Data.Objects.ObjectResult<slots_talent_unavailable_Result> slots_talent_unavailable(int? aGENCY, int? sLOT);
        System.Data.Objects.ObjectResult<int?> smartcollection_create(int? aGENCY, int? lOGIN, string nAME, string mETRICS);
        System.Data.Entity.DbSet<smartcollection_metrics> smartcollection_metrics { get; set; }
        System.Data.Objects.ObjectResult<smartcollection_talent_list_Result> smartcollection_talent_list(int? aGENCY, int? cOLLECTION);
        System.Data.Entity.DbSet<state> states { get; set; }
        System.Data.Objects.ObjectResult<string> states_list();
        System.Data.Entity.DbSet<tag_usage> tag_usage { get; set; }
        System.Data.Entity.DbSet<tag> tags { get; set; }
        System.Data.Objects.ObjectResult<tags_list_Result> tags_list(int? aGENCY, int? lOGIN, int? eVENT, int? cLIENT, int? tALENT);
        System.Data.Objects.ObjectResult<tags_list_records_Result> tags_list_records(int? lOGIN, int? aGENCY, string tAG);
        System.Data.Objects.ObjectResult<tags_list_top_Result> tags_list_top(int? aGENCY, int? lOGIN);
        System.Data.Objects.ObjectResult<int?> talent_apply_approve(int? lOGIN, int? aGENCY, int? aPPLICANT, bool? eXCLUSIVE);
        System.Data.Objects.ObjectResult<int?> talent_apply_deny(int? lOGIN, int? aGENCY, int? aPPLICANT);
        System.Data.Objects.ObjectResult<talent_apply_fetch_Result> talent_apply_fetch(int? aGENCY, int? iD);
        System.Data.Objects.ObjectResult<talent_apply_finalize_Result> talent_apply_finalize(int? lOGIN);
        System.Data.Objects.ObjectResult<talent_apply_general_Result> talent_apply_general(int? lOGIN, string bIRTHDATE, string pHONE, string lOCATION_NAME, string lOCATION_URL, decimal? lOCATION_LAT, decimal? lOCATION_LONG, string bIOGRAPHY);
        System.Data.Objects.ObjectResult<talent_apply_list_Result> talent_apply_list(int? aGENCY);
        System.Data.Objects.ObjectResult<talent_apply_new_Result> talent_apply_new(int? aGENCY, string fIRSTNAME, string lASTNAME, string eMAIL, string pASSWORD);
        System.Data.Objects.ObjectResult<int?> talent_apply_spam(int? lOGIN, int? aGENCY, int? aPPLICANT);
        System.Data.Objects.ObjectResult<talent_apply_upload_Result> talent_apply_upload(int? lOGIN);
        System.Data.Objects.ObjectResult<int?> talent_biography_edit(int? lOGIN, int? aGENCY, int? iD, string bIOGRAPHY);
        System.Data.Objects.ObjectResult<int?> talent_delete(int? lOGIN, int? aGENCY, int? iD);
        System.Data.Objects.ObjectResult<talent_directory_Result> talent_directory(int? lOGIN, int? aGENCY);
        System.Data.Objects.ObjectResult<talent_edit_Result> talent_edit(int? lOGIN, int? aGENCY, int? iD, string fIRSTNAME, string lASTNAME, string sTAGENAME, string eMAIL, string pHONE, string cELL, string hOME, bool? fEATURED, bool? aCTIVE, DateTime? bIRTHDATE, string tAGS, int? mANAGER, string gUARDIAN, string gUARDIANPHONE, string fACEBOOK, string tWITTER, string gPLUS, string iNSTAGRAM, string lINKEDIN, bool? eXCLUSIVE, string lOCATION_NAME, string lOCATION_URL, decimal? lOCATION_LAT, decimal? lOCATION_LONG);
        System.Data.Objects.ObjectResult<int?> talent_experience_edit(int? lOGIN, int? aGENCY, int? iD, string eXPERIENCE);
        System.Data.Objects.ObjectResult<talent_fetch_Result> talent_fetch(int? iD, int? aGENCY);
        System.Data.Objects.ObjectResult<talent_fetch_metrics_Result> talent_fetch_metrics(int? iD);
        System.Data.Objects.ObjectResult<talent_list_events_Result> talent_list_events(int? aGENCY, int? tALENT);
        System.Data.Objects.ObjectResult<talent_list_openeventslots_Result> talent_list_openeventslots(int? aGENCY, int? tALENT, int? mANAGER);
        System.Data.Objects.ObjectResult<talent_list4event_Result> talent_list4event(int? aGENCY, int? eVENT);
        int talent_portfolio_save(int? aGENCY, int? lOGIN, int? iD, string iMAGES);
        System.Data.Objects.ObjectResult<talent_ratebase_add_Result> talent_ratebase_add(int? aGENCY, int? iD, int? tYPE, double? aMOUNT);
        System.Data.Objects.ObjectResult<talent_search_Result> talent_search(int? aGENCY, int? a, int? b, int? c, int? d, int? e, int? f, int? g, int? h, int? i, int? j, double? lAT, double? lONG);
        System.Data.Objects.ObjectResult<testimonial_add_Result> testimonial_add(int? aGENCY, int? tALENT, string aUTHOR, string tESTIMONIAL);
        System.Data.Objects.ObjectResult<int?> testimonial_delete(int? iD, int? aGENCY, int? aUTHUSER);
        System.Data.Objects.ObjectResult<testimonial_edit_Result> testimonial_edit(int? iD, int? aGENCY, int? aUTHUSER, string aUTHOR, string tESTIMONIAL);
        System.Data.Objects.ObjectResult<testimonial_list_Result> testimonial_list(int? aGENCY, int? tALENT);
        System.Data.Entity.DbSet<testimonial> testimonials { get; set; }
        System.Data.Entity.DbSet<v_agency_people> v_agency_people { get; set; }
        System.Data.Entity.DbSet<v_events> v_events { get; set; }
        System.Data.Entity.DbSet<v_log> v_log { get; set; }
        System.Data.Entity.DbSet<v_people_metrics> v_people_metrics { get; set; }
        System.Data.Entity.DbSet<v_slots> v_slots { get; set; }
    }
}

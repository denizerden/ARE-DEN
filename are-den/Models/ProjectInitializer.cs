using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace are_den.Models
{

    public class ProjectInitializer : DropCreateDatabaseIfModelChanges<ProjectContext>
    {

        protected override void Seed(ProjectContext context)
        {

            List<Project> projects = new List<Project>() {

                new Project() { ProjectName="Kulyab Kalaikhumb Yolu / Shurabad – Shagon Bölümü (40 km) ve (1,320 mt) köprü", AgreementType="Anahtar Teslimi İnşaat", Contractor="SUMMA Turizm Yat. A.Ş. / Combined GR.-TEKAR TEK.  ARAŞ. LTD.", Employer="Tajikistan  Ulaştırma Bakanlığı - Shagon - Zigar PIU Kurumu", Placement="Shagon / Tacikistan", StartDate="2014", EndDate="2015" , Area="40 Km", Duty="Proje Müdürü", OperationTime="Ağustos 2014 – Kasım 2015", ProjectImage="proje1.jpg" },
                new Project() { ProjectName="Sebha Şehri Altyapı Projesinin Tasarım, Proje ve İnşaat işleri", AgreementType="Anahtar Teslimi Altyapı İnşaat", Contractor="CENGİZ LİBYA İNŞAAT", Employer="Housing and Infrastructure Board (HIB) LİBYA", Placement="Sebha / Libya", StartDate="2009", EndDate="2012", Area="3600 ha", Duty="Proje Müdürü", OperationTime="Eylül 2010 – Ağustos 2014", ProjectImage="proje2.jpg" },
                new Project() { ProjectName="Çok Amaçlı Kompleks", AgreementType="Anahtar Teslimi İnşaat", Contractor="ARE-DEN İnş. ve Tur. Yat. Ltd Şirketi (/ VOL-DENSTROY)", Employer="Edinstvo Holding", Placement="Vologda / Rusya", StartDate="2008", EndDate="2020", Area="-1.200.000 m, -8.800 Kentsel Dönüşüm Konutu, -27.500 m2 Yaşam Kompleksi, -56 Lüks villa, -480 ha alt yapı, -6 Mahallenin Sosyal tesisleri ", Duty="Müteahhit ve Proje Müdürü", OperationTime="Mayıs 2008 – Eylül 2010 (Krizden dolayı proje durduruldu)", ProjectImage="proje3.jpg" },
                new Project() { ProjectName="TANDEM AVM", AgreementType="Anahtar Teslimi İnşaat", Contractor="ARE-DEN İnş. ve Tur. Yat. Ltd Şirketi (/ VOL-DENSTROY)", Employer="Tandem Holding", Placement="Yaroslavl / Rusya", StartDate="2010", EndDate="2010", Area="43.750 m^2", Duty="Müteahhit ve Proje Müdürü", OperationTime="Mayıs 2008 – Eylül 2010 ", ProjectImage="proje4.jpg" },
                new Project() { ProjectName="Çok Amaçlı Kompleks", AgreementType="Anahtar Teslimi İnşaat", Contractor="KOÇAK YATIRIM İNŞAAT",Employer="Edinstvo Holding", Placement="Vologda / Rusya", StartDate="2007", EndDate="2009", Area="132.200 m^2 -62 125 m2 AVM , -9 450 m2 kapalı otapark,-B sınıf, .450 kişilik konferans salonu bulunan, -12 199 m2 iş merkezi, -4 *, 220 odalı, 16 121 m2 otel, -SPA, fitness merkezi, kapalı yüzme havuzu ve 600 kişiye hizmet verebilen 11 450 m2 aquapark, -8 100 m2 kapalı buz hokeyi sahası, -Basketbol, voleybol, mini futbol amaçlı kullanılabilen 5 000 m2  kapalı spor salonu, -Bowling, bilardo, çocuk eğlence odaları, gece klübü, restaurant bulunan 7 780 m2 eğlence kompleksi", Duty="Proje Müdürü", OperationTime="Ocak 2007 – Mayıs 2010 ", ProjectImage="proje5.jpg" },
                new Project() {
                ProjectName="Vernisage Alışveriş Merkezi",
                AgreementType="Anahtar Teslimi İnşaat",
                Contractor="RÖNESANS HOLDİNG",
                Employer="Global 1 A.Ş.",
                Placement="Yaroslavl / Rusya",
                StartDate="2005",
                EndDate="2006" ,
                Area="42.000 m^2^",
                Duty="Proje Müdürü",
                OperationTime="Kasım 2005 – Ocak 2007",
                ProjectImage="proje6.jpg"
                },
                new Project() {
                ProjectName="Dangara Vadisi Sulama Projesinin Tasarım, Proje ve İnşaat işleri",
                AgreementType="Anahtar Teslimi Sulama İnşaat",
                Contractor="SUMMA Turizm Yat. A.Ş.  / AGE-TEKAR TEKNİK ARAŞ. LTD.",
                Employer="Tacikistan Devleti Su Bakanlığı ",
                Placement="Dangara / Tacikistan",
                StartDate="2004",
                EndDate="2005" ,
                Area="2500 ha",
                Duty="Proje Müdürü",
                OperationTime="Aralık 2004 – Kasım 2005",
                ProjectImage="proje7.jpg"
                },
                new Project() {
                ProjectName="Orta Tokoy Sulama Barajının Full Rehabilitasyonu İşlerinin Teslimi",
                AgreementType="Anahtar Teslim Rehabilitasyon",
                Contractor="SUMMA Turizm Yat. A.Ş.  / AGE-TEKAR TEKNİK ARAŞ. LTD.",
                Employer="Kırgızistan Devleti Su Bakanlığı / World Bank",
                Placement="Orto Tokoi / Balıkçı / Kırgızistan",
                StartDate="1999",
                EndDate="2002" ,
                Area="-",
                Duty="Proje Müdürü",
                OperationTime="Nisan 2004 – Aralık 2004",
                ProjectImage="proje8.jpg"
                },
                new Project() {
                ProjectName="Tvoya Semya Alışveriş Merkezi  ",
                AgreementType="Anahtar Teslim İnşaat",
                Contractor="SUMMA Turizm Yat. A.Ş.",
                Employer="EKS Holding  ",
                Placement="Perm / Rusya",
                StartDate="2003",
                EndDate="2004" ,
                Area="30.800 m^2",
                Duty="Proje Müdürü",
                OperationTime=":Mart 2003 – Nisan 2004",
                ProjectImage="proje9.jpg"
                },
                new Project() {
                ProjectName="İş Geliştirme",
                AgreementType="Anahtar Teslim İnşaat",
                Contractor="SUMMA Turizm Yat. A.Ş.",
                Employer="Tataristan Cumhuriyeti",
                Placement="Kazan",
                StartDate="2002",
                EndDate="-" ,
                Area="-",
                Duty="Tataristan Ülke Müdürü ve Rusya İş Geliştirme Sorumlusu",
                OperationTime="Ocak 2002 – Mart 2003",
                ProjectImage="proje10.jpg"
                },
                new Project() {
                ProjectName="Orta Tokoy Sulama Barajının Full Rehabilitasyonu İşlerinin Tasarım, Proje ve İnşaatı",
                AgreementType="Anahtar Teslim Rehabilitasyon",
                Contractor="SUMMA Turizm Yat. A.Ş. / TEKAR TEKNİK ARAŞTIRMA LTD.",
                Employer="Kırgızistan Devleti Su Bakanlığı / World Bank",
                Placement="Orto Tokoi / Balıkçı / Kırgızistan",
                StartDate="1999",
                EndDate="2002" ,
                Area="-",
                Duty="Proje Müdürü",
                OperationTime="Kasım 1999 – Ocak 2002",
                ProjectImage="proje11.jpg"
                },
                new Project() {
                ProjectName="Ceyrah Sanatoryum",
                AgreementType="Anahtar Teslim İnşaat",
                Contractor="SUMMA Turizm Yat. A.Ş.",
                Employer="İnguşetiya Cumhuriyeti / Rusya",
                Placement="Ceyrah, İnguşetya Cumhuriyeti ",
                StartDate="1997",
                EndDate="1999" ,
                Area="15.800 m^2",
                Duty="Proje Müdürü",
                OperationTime="Kasım 1997 – Kasım 1999",
                ProjectImage="proje12.jpg"
                },
                new Project() {
                ProjectName="Supsa Onshore Terminali Zemin İyileştirme İşleri",
                AgreementType="Anahtar Teslim İnşaat",
                Contractor="SUMMA Turizm Yat. A.Ş. / TEKAR TEKNİK ARAŞTIRMA LTD.",
                Employer="Kvaerner John Brown / Keller",
                Placement="Supsa / Gürcistan ",
                StartDate="1996",
                EndDate="1998" ,
                Area="13.800 m^2",
                Duty="Proje Müdürü",
                OperationTime="Haziran 1997 – Kasım 1997",
                ProjectImage="proje13.jpg"
                },
                new Project() {
                ProjectName="NATEK İş Merkezi",
                AgreementType="Anahtar Teslim İnşaat",
                Contractor="SUMMA Turizm Yat. A.Ş.",
                Employer="NATEK Co.",
                Placement="Moskova",
                StartDate="1996",
                EndDate="1997" ,
                Area="3.800 m^2",
                Duty="Proje Müdürü",
                OperationTime="Kasım 1996 – Haziran 1997",
                ProjectImage="proje14.jpg"
                },
                new Project() {
                ProjectName="Baskı Tesisi (Matbaa)",
                AgreementType="Anahtar Teslim İnşaat",
                Contractor="SUMMA Turizm Yat. A.Ş.",
                Employer="Rissan Construction Ltd.",
                Placement="Nazran, İnguşetya Cumhuriyeti",
                StartDate="1996",
                EndDate="1996" ,
                Area="3.500 m^2",
                Duty="Proje Müdürü",
                OperationTime="Şubat 1996 – Kasım 1996",
                ProjectImage="proje15.jpg"
                },
                new Project() {
                ProjectName="Green Hills Süpermarket",
                AgreementType="Anahtar Teslim Reconstrüksiyon",
                Contractor="SUMMA Turizm Yat. A.Ş.",
                Employer="Green Hills Trust",
                Placement="Kişinev / Moldova",
                StartDate="1996",
                EndDate="1996" ,
                Area="4.000 m^2",
                Duty="Proje Müdürü",
                OperationTime="Ağustos 1995 – Şubat 1996",
                ProjectImage="proje16.jpg"
                },
                new Project() {
                ProjectName="Mercury Bank Full Reconstrüksiyon",
                AgreementType="Anahtar Teslim Reconstrüksiyon",
                Contractor="SUMMA Turizm Yat. A.Ş.",
                Employer="Mercury Bank",
                Placement="Bişkek / Kırgızistan",
                StartDate="1995",
                EndDate="1995" ,
                Area="1.300 m^2",
                Duty="Proje Müdürü",
                OperationTime="Şubat 1995 – Ağustos 1995",
                ProjectImage="proje17.jpg"
                },
                new Project() {
                ProjectName="Sanatorium Firuze",
                AgreementType="Anahtar Teslim İnşaat",
                Contractor="SUMMA Turizm Yat. A.Ş.",
                Employer="Türkmenistan Devlet Memnuniyeti 'Türkmengaz' ",
                Placement="Firuze / Türkmenistan",
                StartDate="1993",
                EndDate="1995" ,
                Area="15.000 m^2",
                Duty="Proje Müdürü Yardımcısı",
                OperationTime="Ekim 1993 – Şubat 1995",
                ProjectImage="proje18.jpg"
                },
                new Project() {
                ProjectName="ABD Büyükelçiliği Binası",
                AgreementType="Anahtar Teslim İnşaat",
                Contractor="SUMMA Turizm Yat. A.Ş.",
                Employer="M.F. Malone Co",
                Placement="Aşkabat / Türkmenistan",
                StartDate="1992",
                EndDate="1993" ,
                Area="5.000 m^2",
                Duty="Saha Mühendisi",
                OperationTime="Haziran 1993 – Ekim 1993",
                ProjectImage="proje19.jpg"
                },
                new Project() {
                ProjectName="Gara Altın Presidential Guest House ve Yol Boyu Sulama Sistemi",
                AgreementType="Anahtar Teslim İnşaat",
                Contractor="SUMMA Turizm Yat. A.Ş.",
                Employer="Türkmenistan Petrol ve Gaz Bakanlığı",
                Placement="Aşkabat / Türkmenistan",
                StartDate="1992",
                EndDate="1993" ,
                Area="10.000 m2 / 44.000 m2",
                Duty="Saha Mühendisi",
                OperationTime="Haziran 1993 – Ekim 1993",
                ProjectImage="proje20.jpg"
                },
                new Project() {
                ProjectName="Adana Galleria Alışveriş Merkezi ve Eğlence Merkezi",
                AgreementType="Anahtar Teslim İnşaat",
                Contractor="SUMMA Turizm Yat. A.Ş.",
                Employer="Anakent Turizm Yatırım A.Ş. & Adana Belediyesi ",
                Placement="Adana",
                StartDate="1991",
                EndDate="1993" ,
                Area="42.000 m^2",
                Duty="Saha Mühendisi",
                OperationTime="Aralık 1991 – Haziran 1993",
                ProjectImage="proje21.jpg"
                },
                new Project() {ProjectName="Dicle Barajı ve Hidroelektrik Santrali ", AgreementType="Anahtar Teslim İnşaat", Contractor="KİSKA İNŞAAT A.Ş.", Employer="DSİ", Placement="Dicle / Diyarbakır", StartDate="1986", EndDate="1997" , Area="-", Duty="Saha Mühendisi", OperationTime="Haziran 1991 - Aralık 1991 ", ProjectImage="proje22.jpg" },
            };
            foreach (var item in projects)
            {
                Console.WriteLine(item);
                context.Projects.Add(item);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); //MVC Servislerinin Eklenmesi
var app = builder.Build();

app.MapControllerRoute(name: "default", pattern: "{Controller=Home}/{Action=Index}");//Routing Konfigürasyonu/Varsayılan Routing

app.UseStaticFiles();//Statik Dosyaların Kullanımının Belirtilmesi


app.Run();






/*

Controller - Action - Model -  View - Razor - RazorView - wwwroot kavramlarının 
ve builder.Build() - app.Run() metotlarının ne işe yaradıklarını,  
hangi amaçla kullanıldıklarını Program.cs'in en alt kısmında yorum satırı olarak açıklayınız.

Controller: Controller, istemciden gelen HTTP isteklerini işleyerek uygun Model veya View ile çalışarak yanıt döndüren bir sınıftır.
Action: Controller içinde tanımlanan ve belirli bir HTTP isteğini işleyen metottur. Örneğin, bir listeleme veya form gönderme işlemini yönetir.
Model: Model, uygulamanın verilerini ve iş mantığını içeren sınıftır. Veritabanı işlemleri veya iş kuralları gibi görevleri üstlenir.
View: View, kullanıcıya gösterilecek HTML içeriğini oluşturur. Modelden gelen verileri alarak dinamik bir sayfa oluşturur.
wwwrot: Statik dosyaların bulunduğu klasör. 
builder.Build(): Servisleri yükleyerek uygulama nesnesini oluşturan metottur.
app.Run(): Uygulamayı başlatan ve HTTP isteklerini dinleyerek yanıt döndüren metottur.
Razor: ASP.NET Core'da kullanılan bir view engine'dir. 
Dinamik HTML sayfaları oluşturmak için C# kodlarını HTML içine gömmeye olanak tanır. Örn: @Model.Name
RazorView: Razor motoru tarafından işlenmiş ve kullanıcının tarayıcısına gönderilen HTML çıktısıdır. 
View dosyalarındaki Razor sözdizimi çalıştırılarak oluşturulur.

*/


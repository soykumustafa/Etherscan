Proje Açýklamasý
Projemiz https://docs.etherscan.io/getting-started/endpoint-urls Adresindeki Ropsten Web apisinden Masaüstü uygulamamýza veri çekmektektedir.
Proje apisini kullanabileceðimiz yeni bir Web api projesi yazdým .Masaüstü uygulamamda datalarý kendi Web apimden çekiyorum .
Buradaki amaç proje büyüdükçe farklý api adreslerini kaynak olarak aldýðýmda tek merkezden data kontrolünü saðlamak.

Not:Projeyi çalýþtýriken Set as startup proje sýrasý 
1.Soyku.Etherscan.WebApi
2.Soyku.Etherscan.UI

Proje Detaylarý

1.){Soyku.Etherscan.Core}
Note: Web api Çekirdek katmanýmýzdýr

Klasör Adý : ClientFactory
ApiClient -> Herhangi bir api ye baðlanmak için Get,Post Baðlantýsý iþlemlerini tutar.

Klasör Adý : Common
ApiResponse -> Api Response Base Class'ýdýr

Klasör Adý : ResponseRequestModel
Employee -> Ropsten data modelimiz
Request -> Ropsten Request modelimiz

2.){Soyku.Etherscan.WebApi}
Not:Api Katmanýmýzdýr.Baðlanacaðýmýz servisler 

Klasör Adý : Controllers
RopstenController ->Ropsten Controllers class'ýmýz

Klasör Adý : Injections
ApiClient ->ApiClient dependency injection config tutulur

3.){Soyku.Etherscan.UI}

Klasör Adý : Services
RopstenService ->UI tarafýndan gönderilen URL  ile Web api projesine baðlanýp ,Json formatýnda data çeker

Klasör Adý : View -> Ropsten
List -> Ekrandaki parametrelere göre URL oluþturup ,RopstenService ten data çeker








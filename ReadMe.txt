Proje A��klamas�
Projemiz https://docs.etherscan.io/getting-started/endpoint-urls Adresindeki Ropsten Web apisinden Masa�st� uygulamam�za veri �ekmektektedir.
Proje apisini kullanabilece�imiz yeni bir Web api projesi yazd�m .Masa�st� uygulamamda datalar� kendi Web apimden �ekiyorum .
Buradaki ama� proje b�y�d�k�e farkl� api adreslerini kaynak olarak ald���mda tek merkezden data kontrol�n� sa�lamak.

Not:Projeyi �al��t�riken Set as startup proje s�ras� 
1.Soyku.Etherscan.WebApi
2.Soyku.Etherscan.UI

Proje Detaylar�

1.){Soyku.Etherscan.Core}
Note: Web api �ekirdek katman�m�zd�r

Klas�r Ad� : ClientFactory
ApiClient -> Herhangi bir api ye ba�lanmak i�in Get,Post Ba�lant�s� i�lemlerini tutar.

Klas�r Ad� : Common
ApiResponse -> Api Response Base Class'�d�r

Klas�r Ad� : ResponseRequestModel
Employee -> Ropsten data modelimiz
Request -> Ropsten Request modelimiz

2.){Soyku.Etherscan.WebApi}
Not:Api Katman�m�zd�r.Ba�lanaca��m�z servisler 

Klas�r Ad� : Controllers
RopstenController ->Ropsten Controllers class'�m�z

Klas�r Ad� : Injections
ApiClient ->ApiClient dependency injection config tutulur

3.){Soyku.Etherscan.UI}

Klas�r Ad� : Services
RopstenService ->UI taraf�ndan g�nderilen URL  ile Web api projesine ba�lan�p ,Json format�nda data �eker

Klas�r Ad� : View -> Ropsten
List -> Ekrandaki parametrelere g�re URL olu�turup ,RopstenService ten data �eker








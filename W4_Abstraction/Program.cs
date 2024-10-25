using W4_Abstraction;


    // Sirket nesneleri oluşturalım
    Sirket yazilimci = new YazilimGelistirici("Ahmet", "Yılmaz", "Yazılım Gelistirici");
    Sirket projeYoneticisi = new ProjeYoneticisi("Hasan", "Çıldırmış", "Proje Yönetimi");
    Sirket satisTemsilcisi = new SatisTemsilcisi("Merve", "Kara", "Satış Temsilcisi");

    // Görevlerini çağıralım
    yazilimci.Gorev();
    projeYoneticisi.Gorev();
    satisTemsilcisi.Gorev();

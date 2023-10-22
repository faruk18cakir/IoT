#include <ESP8266WiFi.h>
#include <WiFiClient.h>

//Bağlanılacak WiFi ağı bilgileri
const char* ssid = "-"; //Biligisayarın bağlı olduğu WiFi ağı (SSID)
const char* password = "-"; //Biligisayarın bağlı olduğu WiFi ağı şifresi

//Röle bağlantı pinleri
const int relayPin = D1; //ESP8266 üzerinde kullanılacak GPIO pini
//const int relayPin1 = D0; 

//TCP sunucusu
WiFiServer server(8080);

void setup() {
  Serial.begin(115200);

  //WiFi ağına bağlanmak için
  WiFi.begin(ssid, password);
  while (WiFi.status() != WL_CONNECTED) {
    delay(1000);
    Serial.println("WiFi ağına bağlanılıyor...");
  }

  Serial.println("WiFi bağlantısı başarıyla sağlandı.");

  //IP adresinin seri porta görüntülenebilmesi için
  Serial.println(WiFi.localIP());

  //Röle pini çıkış olarak ayarlandı
  pinMode(relayPin, OUTPUT);
  //pinMode(relayPin1, OUTPUT);
  //Röle varsayılan olarak kapatıldı
  digitalWrite(relayPin, HIGH);
  //digitalWrite(relayPin1, HIGH);

  //TCP sunucusunu başlatmak için
  server.begin();
  Serial.println("Sunucu başlatıldı. Bağlantı bekleniyor...");
}

void loop() {
  //İstemciden gelen bağlantıyı kontrol etmek için
  WiFiClient client = server.available();
  if (client) {
    Serial.println("Yeni istemci bağlantısı");

    while (client.connected()) {
      if (client.available()) {
        //İstemciden gelen veriyi okumak için
        String data = client.readStringUntil('\n');
        data.trim();

        //Gelen veriyi seri porta yazdırmak için
        Serial.println("İstemciden gelen veri: " + data);

        //Gelen komutu işleyebilmek için
        if (data == "AC") {
          //Fişi açma komutu için
          Serial.println("Fiş açılıyor...");
          digitalWrite(relayPin, LOW); //Röleyi aktifleştirmek için
          //digitalWrite(relayPin1, LOW);
          Serial.println("Fiş açıldı.");
        } else if (data == "KAPAT") {
          // Fişi kapatma komutu
          Serial.println("Fiş kapatılıyor...");
          digitalWrite(relayPin, HIGH); //Röleyi pasifleştirmek için
          //digitalWrite(relayPin1, HIGH);
          Serial.println("Fiş kapatıldı.");
        } else if (data == "CIKIS") {
          //İstemci çıkış komutu için
          Serial.println("İstemci bağlantısı kapatılıyor...");
          break;
        }
      }
    }

    //İstemci bağlantısını kapatmak için
    client.stop();
    Serial.println("İstemci bağlantısı kapatıldı.");
  }
}

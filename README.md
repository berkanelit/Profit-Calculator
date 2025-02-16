Binance Trading Bot
Bu proje, Binance kripto para borsasında otomatik alım-satım işlemleri gerçekleştiren bir trading botudur. DEMA (Double Exponential Moving Average) indikatörünü kullanarak alım-satım sinyalleri üretir ve Telegram üzerinden bildirimler gönderir.

Özellikler
DEMA indikatörü ile teknik analiz
Otomatik alım-satım işlemleri
Telegram bildirimleri
Risk yönetimi (stop-loss ve take-profit)
JSON dosyasında işlem verilerinin saklanması
Ping kontrolü ve sistem performans izleme
Gereksinimler
Python 3.7+
pandas
pandas_ta
python-binance
pyTelegramBotAPI
Kurulum
Gerekli kütüphaneleri yükleyin:
BASH

pip install pandas pandas_ta python-binance pyTelegramBotAPI
Binance API anahtarlarınızı ve Telegram bot token'ınızı kod içerisinde ilgili yerlere ekleyin:
Python

api_key = 'YOUR_API_KEY'
secret_key = 'YOUR_SECRET_KEY'
bot_token = "YOUR_BOT_TOKEN"
chat_id = YOUR_CHAT_ID
Kullanım
Botu çalıştırmak için:

BASH

python bot.py
Önemli Notlar
Bot çalıştırılmadan önce Binance hesabınızda yeterli USDT bakiyesi olduğundan emin olun
Risk yönetimi parametrelerini (stop-loss, take-profit) kendi risk toleransınıza göre ayarlayın
Test ortamında deneyip, gerçek işlemlere geçmeden önce botun davranışını gözlemleyin
Detaylı Rehber
Trading botu geliştirme hakkında daha detaylı bilgi için:
[Python ile Trading Botu Geliştirme - Kapsamlı Rehber](https://metaprora.com/python-ile-trading-botu-gelistirme-kapsamli-rehber/)

İletişim
Daha fazla bilgi ve güncellemeler için:
Metaprora.com

Lisans
Bu proje MIT lisansı altında lisanslanmıştır. Detaylar için LICENSE dosyasına bakın.

Sorumluluk Reddi
Bu bot eğitim amaçlıdır ve finansal tavsiye niteliği taşımaz. Kripto para piyasalarında trading yapmak yüksek risk içerir. Tüm trading kararlarınızdan kendiniz sorumlusunuz.

# Plate Validator

Bu proje, Türkiye'ye ait plaka numaralarını doğrulamak için kullanılan basit bir araçtır. Hem JavaScript (JS) hem de C# (CS) sürümleri bulunmaktadır. Kullanıcılar plaka numaralarını girerek geçerli olup olmadığını kontrol edebilirler.

## İçindekiler

- [Proje Tanımı](#proje-tanımı)
- [Nasıl Çalıştırılır?](#nasıl-çalıştırılır)
  - [JavaScript](#javascript)
  - [C#](#c)
- [Özellikler](#özellikler)

## Proje Tanımı

Bu proje, Türkiye'deki plaka numaralarını belirli bir formatta doğrulayan ve Türkçe karakterlerin girişini engelleyen bir doğrulama mekanizması sunar.

### Geçerli Plaka Formatı:

- **X 1234**: 1 harf, 4 rakam
- **X 12345**: 1 harf, 5 rakam
- **XX 123**: 2 harf, 3 rakam
- **XX 1234**: 2 harf, 4 rakam
- **XXX 12**: 3 harf, 2 rakam
- **XXX 123**: 3 harf, 3 rakam

Türkçe karakterler (Ğ, Ü, Ş, İ, Ö, Ç) plaka numarasının harf kısmında geçersizdir.

## Nasıl Çalıştırılır?

### JavaScript (JS)

1. **Dosyaları İndirin**:

   - Projeyi bilgisayarınıza indirerek `TurkishPlateRegexValidator.js` dosyasını kullanabilirsiniz.

2. **Çalıştırmak için**:

   - Dosyayı çalıştırmak için [Node.js](https://nodejs.org/) yüklü olmalıdır.
   - Terminal veya komut istemcisini açın ve şu komutu kullanarak dosyayı çalıştırın:

     ```bash
     node TurkishPlateRegexValidator.js
     ```

3. **Plaka Girişi**:
   - Program size plaka numarası girmeyi isteyecektir. Geçerli veya geçersiz plakalar hakkında bilgi alabilirsiniz.

### C# (CS)

#### Visual Studio veya IDE Kullanarak:

1. **Projeyi Derleme ve Çalıştırma**:

   - Eğer Visual Studio veya başka bir IDE kullanıyorsanız, C# kodunu bir **Console Application** olarak çalıştırabilirsiniz.
   - `TurkishPlateRegexValidator.cs` dosyasını oluşturun ve şu adımları izleyin:

     1. Yeni bir **Console App** projesi oluşturun:

        ```bash
        dotnet new console -n TurkishPlateValidatorApp
        ```

     2. `TurkishPlateRegexValidator.cs` dosyasını proje dizinine ekleyin.

     3. Projeyi derleyin ve çalıştırın:
        ```bash
        dotnet run
        ```

#### `dotnet-script` Kullanarak:

`dotnet-script` kullanarak, herhangi bir proje oluşturmadan sadece `TurkishPlateRegexValidator.cs` dosyasını çalıştırabilirsiniz. Aşağıdaki adımları izleyin:

1. **dotnet-script Yükleyin**:

   - `dotnet-script` yüklü değilse, aşağıdaki komutu kullanarak yükleyebilirsiniz:
     ```bash
     dotnet tool install -g dotnet-script
     ```

2. **C# Dosyasını Çalıştırın**:

   - `TurkishPlateRegexValidator.cs` dosyasını bulunduğu dizinde şu komut ile çalıştırabilirsiniz:
     ```bash
     dotnet-script TurkishPlateRegexValidator.cs
     ```

3. **Plaka Girişi**:
   - Program, size plaka numarası girmenizi isteyecektir. "exit" yazarak uygulamayı sonlandırabilirsiniz.

## Özellikler

- Geçerli Türk plakaları için regex doğrulaması.
- Türkçe karakterlerin (Ğ, Ü, Ş, İ, Ö, Ç) engellenmesi.
- Hem JavaScript hem de C# platformunda çalışabilir.
- Kullanıcıdan plaka girişi alır ve geçerliliğini kontrol eder.

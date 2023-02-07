# XUML UI課程筆記

專題有空弄個UML唬唬人面試用

快捷鍵: btn_click在xaml宣告完後，按F12會自動在c#後端產生
## 課程目的
跨平台的XAML


### Csharp語言
```csharp=
Button x = new Button();
x.Text = "OK"
```
### 標籤化語言XAML
```xml=
<Button Text="OK"></Button>
```




![](https://i.imgur.com/V7keX5Y.png)

## First start
### 開啟專案
![](https://i.imgur.com/nEjqoAq.png)
### 檔案內容說明
![](https://i.imgur.com/LjgpeyI.png)

### 開啟Android裝置管理員
![](https://i.imgur.com/uIugeGl.png)

### 開啟Hyper
專業版以上才有，沒有的話要下載haxm:
https://github.com/intel/haxm/releases


![](https://i.imgur.com/wmfFIYy.png)

### 賣親朋好友的Android
低功耗，加上通訊層，培養iphone的競爭對手。
iphone 2007年初，Android 2009出來，

![](https://i.imgur.com/QUhlgRB.png)
### Android與各種語言的API
Java寫商用的app
c++ 遊戲場商用openGL每秒16偵動畫，JAVA本身只有8偵
侵權故事:google寫的Android runtime仿java的。oracle買java，創辦人看到JVM和Android runtime87%像，Android是open source，所以google是侵權但不用賠。google說如果若java再吵，我。

Linux可以用微軟的通訊層，但android不能，Android是open source，所以google是侵權但不用賠，硬體廠每支手機微軟收5-10塊美金，60億美金/年。

![](https://i.imgur.com/qvGE54H.png)
![](https://i.imgur.com/KWjMENy.png)

### 執行模擬器
![](https://i.imgur.com/2bMtqGg.png)

#### (必須接受Android sdk)
![](https://i.imgur.com/yuMPwv9.png)

#### 成功的畫面
![](https://i.imgur.com/lKIxzIt.png)

### 模擬器SDK的設定(若開不起來核對使用)
![](https://i.imgur.com/h02II0R.png)


### 畫面架構
![](https://i.imgur.com/TgRvLna.png)
![](https://i.imgur.com/MCsJYBj.png)

### XAML格式與XML差異

![](https://i.imgur.com/khfGW0t.png)

### 控制項
![](https://i.imgur.com/JzEyoCA.png)

## 小故事
你要什麼電腦自己挑，每個月補助1000，讓公司分期付款。
怎麼定義有制度的公司

![](https://i.imgur.com/W6dQkSR.png)

## 版面配置stackLayout
![](https://i.imgur.com/NwAZaP8.png)

![](https://i.imgur.com/7CJohkZ.png)

![](https://i.imgur.com/Cm75pGq.png)

![](https://i.imgur.com/1DIS1mJ.png)

```xml=
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="Ispan_XAMLUI_MauiApp.MainPage">
    <StackLayout
        HorizontalOptions="FillAndExpand"
        VerticalOptions="FillAndExpand"
        Background="AQUA"
        Orientation="Vertical">
        <Button 
                Background="BLUE"
                HorizontalOptions="FillAndExpand"
                VerticalOptions="FillAndExpand"
                Text="A:1/2" 
                FontSize="32"/>

        <StackLayout
        HorizontalOptions="FillAndExpand"
        VerticalOptions="FillAndExpand"
        Background="AQUA"
        Orientation="Vertical">
            <Button 
                Background="Red"
                HorizontalOptions="FillAndExpand"
                VerticalOptions="FillAndExpand"
                Text="B:1/4"
                FontSize="32"/>
            <Button 
                Background="green"
                HorizontalOptions="FillAndExpand"
                VerticalOptions="FillAndExpand"
                Text="c:1/4"
                FontSize="32"/>


        </StackLayout>
    </StackLayout>

</ContentPage>

```

## 版面配置作業:stackLayout
![](https://i.imgur.com/5YqXBKa.png)

正確答案
```xml=
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="prjHello.MainPage">

    <StackLayout Orientation="Vertical" Spacing="0">
        <StackLayout 
                Orientation="Horizontal" 
                VerticalOptions="FillAndExpand"
                Spacing="0">
            
                <Label Text="紅" 
                    FontSize="30" 
                    VerticalTextAlignment="Center"
                    HorizontalTextAlignment="Center"
                    HorizontalOptions="FillAndExpand"
                    VerticalOptions="FillAndExpand"
                    Background="#E63F00"/>
            <Label Text="藍" FontSize="30" 
                    HorizontalTextAlignment="Center"
                   VerticalTextAlignment="Center"
                    HorizontalOptions="FillAndExpand"
                    VerticalOptions="FillAndExpand"
                    Background="#0066FF"/>
            <Label Text="黃" 
                    FontSize="30" 
                    VerticalTextAlignment="Center"
                    HorizontalTextAlignment="Center"
                    HorizontalOptions="FillAndExpand"
                    VerticalOptions="FillAndExpand"
                    Background="#FFFF00"/>
            <Label Text="綠" FontSize="30" 
                    HorizontalTextAlignment="Center"
                   VerticalTextAlignment="Center"
                    HorizontalOptions="FillAndExpand"
                    VerticalOptions="FillAndExpand"
                    Background="#01814A"/>
        </StackLayout>
        <StackLayout 
                Orientation="Vertical" 
                VerticalOptions="FillAndExpand"
                Spacing="0">
            
            <Label
                x:Name="lblHello"
                Text="Hello" FontSize="30" 
               HorizontalTextAlignment="Start"
               HorizontalOptions="FillAndExpand"
               VerticalOptions="FillAndExpand"
               />

            <Label Text="第二行" 
                   TextDecorations="Underline"  
                   FontSize="30" 
               HorizontalTextAlignment="Start"
               HorizontalOptions="FillAndExpand"
               VerticalOptions="FillAndExpand"
               />
            <Label Text="第三行" FontSize="30" 
               HorizontalTextAlignment="Start"
               TextDecorations="Strikethrough" 
               HorizontalOptions="FillAndExpand"
               VerticalOptions="FillAndExpand"
               />
            <Label Text="第四行" FontSize="30" 
               HorizontalTextAlignment="Start"
               HorizontalOptions="FillAndExpand"
               VerticalOptions="FillAndExpand"
               />
        </StackLayout>
    </StackLayout>
</ContentPage>
```


## 元件開發:解一元2次方程式
![](https://i.imgur.com/QACGR5i.png)

![](https://i.imgur.com/9GOjKH8.png)


## Grid
![](https://i.imgur.com/Bj8K7yL.png)



## navigationPage
![](https://i.imgur.com/CrADyc4.png)


## 推薦書籍
![](https://i.imgur.com/WoFvk6u.png)

## 推薦連結

WPF
https://yuchungchuang.wordpress.com/wpf-tutorials/
MAUI
https://ithelp.ithome.com.tw/users/20108931/ironman/5746
iconFinder


Resource共用
https://dotblogs.com.tw/v6610688/2013/11/26/windows8_introduction_resources




















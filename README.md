# Unity_Demo_WriteAndReadData
 Unity 範例：寫入與讀取檔案

網頁展示：https://kid421.github.io/Unity_Demo_WriteAndReadData/Web

# 設定教學
1. 建立結構或類別將需要儲存的資料定義為欄位

範例中要儲存的資料分別為
- 角色座標
- 角色角度
- 角色吃金幣數量

!["寫入與讀取檔案"](/tutorial1.png "寫入與讀取檔案")

2. 定義資料管理類別

建立類別用於管理資料

!["寫入與讀取檔案"](/tutorial2.png "寫入與讀取檔案")

3. 實作資料讀取

※ 行 64 - 66 為取得需要寫入資料的物件
※ 行 58 "儲存資料1" 為資料名稱，可自行命名

!["寫入與讀取檔案"](/tutorial3.png "寫入與讀取檔案")

4. 實作資料寫入

※ 行 93 的 "儲存資料1" 必須與步驟 3. 相同

!["寫入與讀取檔案"](/tutorial4.png "寫入與讀取檔案")

5. 實作按鈕呼叫的公開方法

- GameNew 為【選單】全新冒險 按鈕需要的方法
- GameOld 為【選單】讀取檔案 按鈕需要的方法

- GameSave 為【遊戲場景】存檔 按鈕需要的方法
- BackToMenu 為【遊戲場景】返回選單 按鈕需要的方法

!["寫入與讀取檔案"](/tutorial5.png "寫入與讀取檔案")

6. 選單：建立空物件套用腳本並儲存為預製物

!["寫入與讀取檔案"](/tutorial6.png "寫入與讀取檔案")

7. 遊戲場景：套用預製物

!["寫入與讀取檔案"](/tutorial7.png "寫入與讀取檔案")

## 參考 C# 連結

[玩家資料結構](/WriteAndRead/Assets/Scripts/PlayerData.cs)

[資料管理器](/WriteAndRead/Assets/Scripts/DataManager.cs)
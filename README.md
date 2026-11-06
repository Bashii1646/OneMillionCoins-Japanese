# One Million Coins 日本語化MOD

Steam版 **One Million Coins** のメニュー・装備・スキル・HUDなどを日本語化する非公式MODです。
ゲーム標準の言語一覧に「日本語」を追加します。

## ダウンロード

**[最新版のダウンロードはこちら](https://github.com/Bashii1646/OneMillionCoins-Japanese/releases/latest)**

Releasesの「Assets」にある **`OneMillionCoins-Japanese-v1.0.0.zip`** をダウンロードしてください。
GitHubが自動生成する「Source code (zip)」には、導入用のDLLは含まれていません。

## 必要なもの

- Windows 64bit / Steam版 One Million Coins
- **BepInEx 5.4.23.5 x64 (Mono)**
- Windowsのメイリオ・游ゴシック・MSゴシックのいずれか

動作確認したゲームのSteam buildは **26367772**、Unityは **6000.6.0f1** です。
BepInEx本体はこのMODのZIPには同梱していません。

## 導入方法

1. ゲームを終了します。
2. Steamでゲームを右クリックし、**管理 → ローカルファイルを閲覧** を開きます。
3. [BepInEx公式配布ページ](https://github.com/BepInEx/BepInEx/releases/tag/v5.4.23.5)から **`BepInEx_win_x64_5.4.23.5.zip`** をダウンロードし、`One Million Coins.exe`と同じ場所へ展開します。
4. 日本語化MODのZIP内にある **`BepInEx`フォルダ** を、同じゲームフォルダへコピーします。
5. Steamから起動します。初回は日本語が自動選択されます。以降はメインメニューまたは設定の言語一覧で **日本語** を選べます。

```text
One Million Coins/
├─ One Million Coins.exe
├─ winhttp.dll
├─ doorstop_config.ini
└─ BepInEx/
   ├─ core/
   └─ plugins/
      └─ JapaneseLocalization/
         ├─ JapaneseLocalization.dll
         └─ ja.json
```

BepInEx 5が導入済みなら、手順3は不要です。BepInEx 6・IL2CPP向けではありません。
同じ日本語化MODの古いDLLを別のフォルダに残さないでください。

## 更新・削除

更新時はゲームを終了し、`JapaneseLocalization.dll`と`ja.json`を上書きしてください。変更は再起動後に反映されます。

無効化するには、ゲーム終了後に`JapaneseLocalization.dll`を`JapaneseLocalization.dll.disabled`へ変更します。
削除する場合は`BepInEx/plugins/JapaneseLocalization`フォルダを削除してください。
他のMODを使っている場合は、BepInEx本体を削除しないでください。

## 翻訳・対応状況

- 翻訳エントリ **4,604件**（表記違い・旧バージョン向けを含む）
- 機械翻訳を下地に、用語や意味の誤りを修正
- メニュー・設定・ゲーム内HUDの表示を確認
- 利用者から100万コイン回収までのプレイ完了報告あり
- 全翻訳の書式変数・装飾タグ・置換変数を検査し、条件文など108ケースをオフライン検査

不自然な訳や未翻訳が残る場合があります。全画面のレイアウト、将来のゲーム更新、他の言語追加MODとの併用は未確認です。
ゲーム本体のDLLやアセットは書き換えません。実行中に翻訳サービスへ接続する機能もありません。

## 不具合の報告

[Issues](https://github.com/Bashii1646/OneMillionCoins-Japanese/issues)に、該当箇所の画像、ゲームのbuild番号、他のMODの有無を添えて報告してください。
`BepInEx/LogOutput.log`の「Japanese localization ready」が読み込み成功の目印です。
ログを添付する場合は、個人情報が含まれていないか確認してください。

## ソースコード

プラグインのソースは[`source/JapaneseLocalization.cs`](source/JapaneseLocalization.cs)、翻訳は[`ja.json`](BepInEx/plugins/JapaneseLocalization/ja.json)です。
ビルド方法は[`source/README.txt`](source/README.txt)を参照してください。ゲーム本体やBepInExのDLLはローカルのインストール先から参照します。

## ライセンス・クレジット

MOD独自のプラグインコードとビルドスクリプトは[MIT License](LICENSE.txt)です。
One Million Coinsとその原文の権利は各権利者に帰属します。
MODの読み込みには[BepInEx](https://github.com/BepInEx/BepInEx)と、その配布に含まれるHarmonyを利用しています。
本MODはゲーム開発元の公式製品ではありません。

One Million Coins 日本語化MOD v1.0.0
配布用パッケージ / 2026-11-06

概要
メニュー・装備・スキル・HUDなどを日本語化する非公式MODです。
ゲーム標準の言語一覧に「日本語」を追加します。
翻訳は機械翻訳を下地に修正しています。不自然な表現が残る場合があります。
ゲーム本体のファイルの書き換えや、実行中の外部翻訳通信は行いません。

対応確認
Windows 64bit / Steam版 One Million Coins build 26367772
Unity 6000.6.0f1 / BepInEx 5.4.23.5 x64 (Mono)
翻訳エントリ: 4,604件（表記違い・旧バージョン向けを含む）
Windowsのメイリオ・游ゴシック・MSゴシックのいずれかが必要です。
BepInEx 6やIL2CPP向けのパッケージは対象外です。

初めて導入する場合
1. ゲームを終了します。
2. Steamでゲームを右クリック → 管理 → ローカルファイルを閲覧。
3. 下記の公式配布から BepInEx_win_x64_5.4.23.5.zip を入手し、
   One Million Coins.exeと同じ場所へ展開します。
   https://github.com/BepInEx/BepInEx/releases/tag/v5.4.23.5
4. このZIP内のBepInExフォルダを、同じゲームフォルダへコピーします。
   最終的に次の配置になれば完了です。
   One Million Coins.exe
   winhttp.dll                        ← BepInExのファイル
   doorstop_config.ini                ← BepInExのファイル
   BepInEx/
     core/                            ← BepInExのファイル
     plugins/
       JapaneseLocalization/
         JapaneseLocalization.dll
         ja.json
5. Steamから起動します。初回は日本語が自動選択されます。
   それ以降はメインメニューか設定の言語一覧から「日本語」を選べます。

BepInEx 5が導入済みの場合
ゲーム終了後、このZIPのBepInExフォルダをゲームフォルダへコピーします。
BepInEx本体の再導入は不要です。同じMODの古いDLLを別フォルダに残さないでください。
OMC Language Managerなど別の言語追加MODとの併用は未確認です。

更新
ゲーム終了後、日本語化MODのJapaneseLocalization.dllとja.jsonを上書きします。
翻訳の変更はゲーム再起動後に反映されます。

無効化・削除
ゲーム終了後、BepInEx/plugins/JapaneseLocalizationフォルダを削除するか、
JapaneseLocalization.dllの拡張子を.dll.disabledに変えます。
言語設定がjaのままでも、MODなしで起動するとゲーム標準の英語に戻ります。
他のMODがある場合はBepInEx本体を削除しないでください。

確認できた範囲
メニュー・設定・ゲーム内HUDの表示を確認済みです。
利用者から100万コイン回収までのプレイ完了報告があります。
4,604件の書式変数・装飾タグ・置換変数を検査し、
オフラインの条件文検査108ケースが通っています。
全画面・全スキルのレイアウトや、将来のゲーム更新との互換性は未確認です。

不具合確認
BepInEx/LogOutput.logに「Japanese localization ready」があるか確認してください。
報告時は、該当箇所の画像・ゲームのbuild番号・他のMODの有無があると助かります。
ログを公開する場合は個人情報が含まれていないか確認してください。

同梱物
BepInEx/plugins/JapaneseLocalization/ : MOD本体と日本語翻訳
source/ : このMODのC#ソースとビルド手順
manifest.json : バージョン・対応確認情報
LICENSE.txt : MODコードのMITライセンス
SHA256SUMS.txt : 同梱ファイルのSHA-256

BepInEx本体、ゲーム本体、逆コンパイルしたゲームコード、フォント、
セーブデータ、個人設定は同梱していません。
本MODはゲーム開発元の公式製品ではありません。

公開・配布について
開発者ShoXxさんから非営利でのMOD公開・配布許可を得ています。
MITライセンスの対象は独自のプラグインコードとビルドスクリプトです。
翻訳データやゲーム原文の商用利用を許諾するものではありません。
詳細はDISTRIBUTION-NOTICE.txtを参照してください。

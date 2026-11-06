One Million Coins - Japanese translation handoff
Contributor: Bashii1646
Translation revision: v1.0.0 (4,604 entries)
Tested game build: Steam 26367772 / Unity 6000.6.0f1

Hi ShoXx,

Thank you for allowing non-commercial distribution of the language mod,
and for offering to consider Japanese support in the official game.

I am happy for you / OYU Games to incorporate, edit, and maintain my Japanese
translation contributions in the official One Million Coins game, including
its commercial release. This is permission for the original developer;
the public unofficial mod is distributed non-commercially.

Contents
  ja.json                Full editable translation catalog, UTF-8
  README-FOR-DEVELOPER.txt  This document
  manifest.json          Revision, compatibility, and file information
  SHA256SUMS.txt         File checksums

Format and integration notes
- The catalog uses the game's existing JSON shape: {"id":"ja","items":[...]}.
- "en" is the English lookup key; "text" is its Japanese translation.
- "group" is organizational metadata.
- Some entries include "match": "template" or "prefix" and the game's
  "numbers" / "names" flags. Keep these when using the existing catalog parser.
- Preserve formatting placeholders such as {0}, {0:N0}, {1:0.##}, input-binding
  tokens such as {Tool2} and {Secondary}, rich-text tags, and $1 replacement
  variables. Numeric slots and input-binding tokens have different roles.
- This catalog contains legacy strings, case variants, numeric aliases, and
  composed UI conditions as well as current strings. 4,604 entries does not
  mean 4,604 distinct current UI messages. You can select or merge the entries
  that fit your current development build.
- For the unofficial mod, BepInEx adds the language and selects a Windows font.
  No BepInEx component is needed to integrate this translation into the game.
  Register Japanese in your language options and provide a font with Japanese
  glyph coverage; the translation alone does not supply fonts or font assets.

Translation quality and validation
- Created with machine translation and AI assistance, followed by corrections
  based on gameplay and offline review. Some wording still needs proofreading.
- The player completed the one-million-coin run with the mod installed.
- All entries were checked for matching placeholders, rich-text tags, and
  replacement variables. 108 offline dynamic-condition/stat cases passed.
- Every screen and every skill has not been visually checked. Layout,
  terminology, and changes in newer builds should be reviewed before an
  official release. This is a contribution for review, not a claim that it
  is a professionally proofread localization.

Repository and public mod
https://github.com/Bashii1646/OneMillionCoins-Japanese
https://github.com/Bashii1646/OneMillionCoins-Japanese/releases/tag/v1.0.0

This ZIP contains translation data and documentation only: no game binaries,
decompiled source, BepInEx, fonts, save data, or personal settings.

Thank you again!
Bashii1646

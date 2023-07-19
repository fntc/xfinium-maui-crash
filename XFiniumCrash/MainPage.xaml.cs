using Xfinium.Pdf;
using Xfinium.Pdf.Graphics;

namespace XFiniumCrash;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        Run();
    }
    
    
    /// <summary>
        /// Main method for running the sample.
        /// </summary>
        public static Stream Run(Stream ttfStream=null)
        {
            PdfFixedDocument document = new PdfFixedDocument();

            PdfPage page = document.Pages.Add();
            DrawStandardFonts(page);

            page = document.Pages.Add();
            DrawStandardCjkFonts(page);
            if (ttfStream != null)
            {
                page = document.Pages.Add();
                DrawTrueTypeFonts(page, ttfStream);

                page = document.Pages.Add();
                DisableTextCopy(page, ttfStream);
            }

            var ms = new MemoryStream(); 
            document.Save(ms);
            ms.Seek(0, SeekOrigin.Begin);
            return ms;
        }

        private static void DrawStandardFonts(PdfPage page)
        {
            PdfStandardFont titleFont = new PdfStandardFont(PdfStandardFontFace.HelveticaBold, 22);
            PdfBrush blackBrush = new PdfBrush(new PdfRgbColor());

            page.Graphics.DrawString("Standard fonts", titleFont, blackBrush, 20, 50);
            page.Graphics.DrawString("(Base 14 PDF fonts supported by any PDF viewer)", titleFont, blackBrush, 20, 75);

            PdfStandardFont helvetica = new PdfStandardFont(PdfStandardFontFace.Helvetica, 16);
            page.Graphics.DrawString("Helvetica - Lorem ipsum dolor sit amet, consectetur adipiscing elit.", helvetica, blackBrush, 20, 125);

            PdfStandardFont helveticaBold = new PdfStandardFont(PdfStandardFontFace.HelveticaBold, 16);
            page.Graphics.DrawString("Helvetica Bold - Lorem ipsum dolor sit amet, consectetur adipiscing elit.", helveticaBold, blackBrush, 20, 150);

            PdfStandardFont helveticaItalic = new PdfStandardFont(PdfStandardFontFace.HelveticaItalic, 16);
            page.Graphics.DrawString("Helvetica Italic - Lorem ipsum dolor sit amet, consectetur adipiscing elit.", helveticaItalic, blackBrush, 20, 175);

            PdfStandardFont helveticaBoldItalic = new PdfStandardFont(PdfStandardFontFace.HelveticaBoldItalic, 16);
            page.Graphics.DrawString("Helvetica Bold Italic - Lorem ipsum dolor sit amet, consectetur adipiscing elit.", helveticaBoldItalic, blackBrush, 20, 200);

            PdfStandardFont timesRoman = new PdfStandardFont(PdfStandardFontFace.TimesRoman, 16);
            page.Graphics.DrawString("Times Roman - Lorem ipsum dolor sit amet, consectetur adipiscing elit.", timesRoman, blackBrush, 20, 225);

            PdfStandardFont timesRomanBold = new PdfStandardFont(PdfStandardFontFace.TimesRomanBold, 16);
            page.Graphics.DrawString("Times Roman Bold - Lorem ipsum dolor sit amet, consectetur adipiscing elit.", timesRomanBold, blackBrush, 20, 250);

            PdfStandardFont timesRomanItalic = new PdfStandardFont(PdfStandardFontFace.TimesRomanItalic, 16);
            page.Graphics.DrawString("Times Roman Italic - Lorem ipsum dolor sit amet, consectetur adipiscing elit.", timesRomanItalic, blackBrush, 20, 275);

            PdfStandardFont timesRomanBoldItalic = new PdfStandardFont(PdfStandardFontFace.TimesRomanBoldItalic, 16);
            page.Graphics.DrawString("Times Roman Bold Italic - Lorem ipsum dolor sit amet, consectetur adipiscing elit.", timesRomanBoldItalic, blackBrush, 20, 300);

            PdfStandardFont courier = new PdfStandardFont(PdfStandardFontFace.Courier, 16);
            page.Graphics.DrawString("Courier - Lorem ipsum dolor sit amet, consectetur adipiscing elit.", courier, blackBrush, 20, 325);

            PdfStandardFont courierBold = new PdfStandardFont(PdfStandardFontFace.CourierBold, 16);
            page.Graphics.DrawString("Courier Bold - Lorem ipsum dolor sit amet, consectetur adipiscing elit.", courierBold, blackBrush, 20, 350);

            PdfStandardFont courierItalic = new PdfStandardFont(PdfStandardFontFace.CourierItalic, 16);
            page.Graphics.DrawString("Courier Italic - Lorem ipsum dolor sit amet, consectetur adipiscing elit.", courierItalic, blackBrush, 20, 375);

            PdfStandardFont courierBoldItalic = new PdfStandardFont(PdfStandardFontFace.CourierBoldItalic, 16);
            page.Graphics.DrawString("Courier Bold Italic - Lorem ipsum dolor sit amet, consectetur adipiscing elit.", courierBoldItalic, blackBrush, 20, 400);
        }

        private static void DrawStandardCjkFonts(PdfPage page)
        {
            PdfStandardFont titleFont = new PdfStandardFont(PdfStandardFontFace.HelveticaBold, 22);
            PdfBrush blackBrush = new PdfBrush(new PdfRgbColor());

            page.Graphics.DrawString("Standard CJK fonts", titleFont, blackBrush, 20, 50);
            page.Graphics.DrawString("(CJK fonts supported by Adobe Reader", titleFont, blackBrush, 20, 75);
            page.Graphics.DrawString(" using CJK language packs)", titleFont, blackBrush, 20, 100);

            PdfStandardFont heiseiKakuGothic = new PdfStandardFont(PdfStandardFontFace.HeiseiKakuGothicW5, 16);
            page.Graphics.DrawString("Heisei Kaku Gothic - ã‚µãƒ³ãƒ—ãƒ«æ—¥æœ¬èªžãƒ•ã‚©ãƒ³ãƒˆãƒ‡ãƒ¢ãƒ†ã‚­ã‚¹ãƒˆ.", heiseiKakuGothic, blackBrush, 20, 150);

            PdfStandardFont heiseiKakuGothicBold = new PdfStandardFont(PdfStandardFontFace.HeiseiKakuGothicW5Bold, 16);
            page.Graphics.DrawString("Heisei Kaku Gothic Bold - ã‚µãƒ³ãƒ—ãƒ«æ—¥æœ¬èªžãƒ•ã‚©ãƒ³ãƒˆãƒ‡ãƒ¢ãƒ†ã‚­ã‚¹ãƒˆ.", heiseiKakuGothicBold, blackBrush, 20, 175);

            PdfStandardFont heiseiKakuGothicItalic = new PdfStandardFont(PdfStandardFontFace.HeiseiKakuGothicW5Italic, 16);
            page.Graphics.DrawString("Heisei Kaku Gothic Italic - ã‚µãƒ³ãƒ—ãƒ«æ—¥æœ¬èªžãƒ•ã‚©ãƒ³ãƒˆãƒ‡ãƒ¢ãƒ†ã‚­ã‚¹ãƒˆ.", heiseiKakuGothicItalic, blackBrush, 20, 200);

            PdfStandardFont heiseiKakuGothicBoldItalic = new PdfStandardFont(PdfStandardFontFace.HeiseiKakuGothicW5BoldItalic, 16);
            page.Graphics.DrawString("Heisei Kaku Gothic Bold Italic - ã‚µãƒ³ãƒ—ãƒ«æ—¥æœ¬èªžãƒ•ã‚©ãƒ³ãƒˆãƒ‡ãƒ¢ãƒ†ã‚­ã‚¹ãƒˆ.", heiseiKakuGothicBoldItalic, blackBrush, 20, 225);

            PdfStandardFont heiseiMincho = new PdfStandardFont(PdfStandardFontFace.HeiseiMinchoW3, 16);
            page.Graphics.DrawString("Heisei Mincho - ã‚µãƒ³ãƒ—ãƒ«æ—¥æœ¬èªžãƒ•ã‚©ãƒ³ãƒˆãƒ‡ãƒ¢ãƒ†ã‚­ã‚¹ãƒˆ.", heiseiMincho, blackBrush, 20, 250);

            PdfStandardFont heiseiMinchoBold = new PdfStandardFont(PdfStandardFontFace.HeiseiMinchoW3Bold, 16);
            page.Graphics.DrawString("Heisei Mincho Bold - ã‚µãƒ³ãƒ—ãƒ«æ—¥æœ¬èªžãƒ•ã‚©ãƒ³ãƒˆãƒ‡ãƒ¢ãƒ†ã‚­ã‚¹ãƒˆ.", heiseiMinchoBold, blackBrush, 20, 275);

            PdfStandardFont heiseiMinchoItalic = new PdfStandardFont(PdfStandardFontFace.HeiseiMinchoW3Italic, 16);
            page.Graphics.DrawString("Heisei Mincho Italic - ã‚µãƒ³ãƒ—ãƒ«æ—¥æœ¬èªžãƒ•ã‚©ãƒ³ãƒˆãƒ‡ãƒ¢ãƒ†ã‚­ã‚¹ãƒˆ.", heiseiMinchoItalic, blackBrush, 20, 300);

            PdfStandardFont heiseiMinchoBoldItalic = new PdfStandardFont(PdfStandardFontFace.HeiseiMinchoW3BoldItalic, 16);
            page.Graphics.DrawString("Heisei Mincho Bold Italic - ã‚µãƒ³ãƒ—ãƒ«æ—¥æœ¬èªžãƒ•ã‚©ãƒ³ãƒˆãƒ‡ãƒ¢ãƒ†ã‚­ã‚¹ãƒˆ.", heiseiMinchoBoldItalic, blackBrush, 20, 325);

            PdfStandardFont hanyangSystemsGothicMedium = new PdfStandardFont(PdfStandardFontFace.HanyangSystemsGothicMedium, 16);
            page.Graphics.DrawString("Hanyang Systems Gothic Medium - ìƒ˜í”Œ í•œêµ­ì–´ ê¸€ê¼´ ë°ëª¨ í…ìŠ¤íŠ¸.", hanyangSystemsGothicMedium, blackBrush, 20, 350);

            PdfStandardFont hanyangSystemsGothicMediumBold = new PdfStandardFont(PdfStandardFontFace.HanyangSystemsGothicMediumBold, 16);
            page.Graphics.DrawString("Hanyang Systems Gothic Medium Bold - ìƒ˜í”Œ í•œêµ­ì–´ ê¸€ê¼´ ë°ëª¨ í…ìŠ¤íŠ¸.", hanyangSystemsGothicMediumBold, blackBrush, 20, 375);

            PdfStandardFont hanyangSystemsGothicMediumItalic = new PdfStandardFont(PdfStandardFontFace.HanyangSystemsGothicMediumItalic, 16);
            page.Graphics.DrawString("Hanyang Systems Gothic Medium Italic - ìƒ˜í”Œ í•œêµ­ì–´ ê¸€ê¼´ ë°ëª¨ í…ìŠ¤íŠ¸.", hanyangSystemsGothicMediumItalic, blackBrush, 20, 400);

            PdfStandardFont hanyangSystemsGothicMediumBoldItalic = new PdfStandardFont(PdfStandardFontFace.HanyangSystemsGothicMediumBoldItalic, 16);
            page.Graphics.DrawString("Hanyang Systems Gothic Medium Bold Italic - ìƒ˜í”Œ í•œêµ­ì–´ ê¸€ê¼´ ë°ëª¨ í…ìŠ¤íŠ¸.", hanyangSystemsGothicMediumBoldItalic, blackBrush, 20, 425);

            PdfStandardFont hanyangSystemsShinMyeongJoMedium = new PdfStandardFont(PdfStandardFontFace.HanyangSystemsShinMyeongJoMedium, 16);
            page.Graphics.DrawString("Hanyang Systems Shin Myeong Jo Medium - ìƒ˜í”Œ í•œêµ­ì–´ ê¸€ê¼´ ë°ëª¨ í…ìŠ¤íŠ¸.", hanyangSystemsShinMyeongJoMedium, blackBrush, 20, 450);

            PdfStandardFont hanyangSystemsShinMyeongJoMediumBold = new PdfStandardFont(PdfStandardFontFace.HanyangSystemsShinMyeongJoMediumBold, 16);
            page.Graphics.DrawString("Hanyang Systems Shin Myeong Jo Medium Bold - ìƒ˜í”Œ í•œêµ­ì–´ ê¸€ê¼´ ë°ëª¨ í…ìŠ¤íŠ¸.", hanyangSystemsShinMyeongJoMediumBold, blackBrush, 20, 475);

            PdfStandardFont hanyangSystemsShinMyeongJoMediumItalic = new PdfStandardFont(PdfStandardFontFace.HanyangSystemsShinMyeongJoMediumItalic, 16);
            page.Graphics.DrawString("Hanyang Systems Shin Myeong Jo Medium Italic - ìƒ˜í”Œ í•œêµ­ì–´ ê¸€ê¼´ ë°ëª¨ í…ìŠ¤íŠ¸.", hanyangSystemsShinMyeongJoMediumItalic, blackBrush, 20, 500);

            PdfStandardFont hanyangSystemsShinMyeongJoMediumBoldItalic = new PdfStandardFont(PdfStandardFontFace.HanyangSystemsShinMyeongJoMediumBoldItalic, 16);
            page.Graphics.DrawString("Hanyang Systems Shin Myeong Jo Medium Bold Italic - ìƒ˜í”Œ í•œêµ­ì–´ ê¸€ê¼´ ë°ëª¨ í…ìŠ¤íŠ¸.", hanyangSystemsShinMyeongJoMediumBoldItalic, blackBrush, 20, 525);

            PdfStandardFont monotypeSungLight = new PdfStandardFont(PdfStandardFontFace.MonotypeSungLight, 16);
            page.Graphics.DrawString("Monotype Sung Light - ä¸­åœ‹å­—é«”æ¨£æœ¬ç¤ºç¯„æ–‡æœ¬.", monotypeSungLight, blackBrush, 20, 550);

            PdfStandardFont monotypeSungLightBold = new PdfStandardFont(PdfStandardFontFace.MonotypeSungLightBold, 16);
            page.Graphics.DrawString("Monotype Sung Light Bold - ä¸­åœ‹å­—é«”æ¨£æœ¬ç¤ºç¯„æ–‡æœ¬.", monotypeSungLightBold, blackBrush, 20, 575);

            PdfStandardFont monotypeSungLightItalic = new PdfStandardFont(PdfStandardFontFace.MonotypeSungLightItalic, 16);
            page.Graphics.DrawString("Monotype Sung Light Italic - ä¸­åœ‹å­—é«”æ¨£æœ¬ç¤ºç¯„æ–‡æœ¬.", monotypeSungLightItalic, blackBrush, 20, 600);

            PdfStandardFont monotypeSungLightBoldItalic = new PdfStandardFont(PdfStandardFontFace.MonotypeSungLightBoldItalic, 16);
            page.Graphics.DrawString("Monotype Sung Light Bold Italic - ä¸­åœ‹å­—é«”æ¨£æœ¬ç¤ºç¯„æ–‡æœ¬.", monotypeSungLightBoldItalic, blackBrush, 20, 625);

            PdfStandardFont sinoTypeSongLight = new PdfStandardFont(PdfStandardFontFace.SinoTypeSongLight, 16);
            page.Graphics.DrawString("Sino Type Song Light - ä¸­å›½å­—ä½“æ ·æœ¬ç¤ºèŒƒæ–‡æœ¬.", sinoTypeSongLight, blackBrush, 20, 650);

            PdfStandardFont sinoTypeSongLightBold = new PdfStandardFont(PdfStandardFontFace.SinoTypeSongLightBold, 16);
            page.Graphics.DrawString("Sino Type Song Light Bold - ä¸­å›½å­—ä½“æ ·æœ¬ç¤ºèŒƒæ–‡æœ¬.", sinoTypeSongLightBold, blackBrush, 20, 675);

            PdfStandardFont sinoTypeSongLightItalic = new PdfStandardFont(PdfStandardFontFace.SinoTypeSongLightItalic, 16);
            page.Graphics.DrawString("Sino Type Song Light Italic - ä¸­å›½å­—ä½“æ ·æœ¬ç¤ºèŒƒæ–‡æœ¬.", sinoTypeSongLightItalic, blackBrush, 20, 700);

            PdfStandardFont sinoTypeSongLightBoldItalic = new PdfStandardFont(PdfStandardFontFace.SinoTypeSongLightBoldItalic, 16);
            page.Graphics.DrawString("Sino Type Song Light Bold Italic - ä¸­å›½å­—ä½“æ ·æœ¬ç¤ºèŒƒæ–‡æœ¬.", sinoTypeSongLightBoldItalic, blackBrush, 20, 725);
        }

        private static void DrawTrueTypeFonts(PdfPage page, Stream ttfStream)
        {
            PdfStandardFont titleFont = new PdfStandardFont(PdfStandardFontFace.HelveticaBold, 22);
            PdfBrush blackBrush = new PdfBrush(new PdfRgbColor());

            page.Graphics.DrawString("TrueType fonts", titleFont, blackBrush, 20, 50);
            page.Graphics.DrawString("(when embedded they should be supported", titleFont, blackBrush, 20, 75);
            page.Graphics.DrawString(" by any PDF viewer)", titleFont, blackBrush, 20, 100);

            PdfAnsiTrueTypeFont ansiVerdana = new PdfAnsiTrueTypeFont(ttfStream, 16, true);
            page.Graphics.DrawString("Verdana - Ansi TrueType font", ansiVerdana, blackBrush, 20, 150);
            page.Graphics.DrawString("Lorem ipsum dolor sit amet, consectetur adipiscing elit.", ansiVerdana, blackBrush, 20, 175);

            ttfStream.Position = 0;
            PdfUnicodeTrueTypeFont unicodeVerdana = new PdfUnicodeTrueTypeFont(ttfStream, 16, true);
            page.Graphics.DrawString("Verdana - Unicode TrueType font", unicodeVerdana, blackBrush, 20, 225);

            page.Graphics.DrawString("Russian - ÐŸÑ€Ð¸Ð¼ÐµÑ€ Ñ€ÑƒÑÑÐºÐ¸Ð¹ Ñ‚ÐµÐºÑÑ‚ Ð´ÐµÐ¼Ð¾ ÑˆÑ€Ð¸Ñ„Ñ‚.", unicodeVerdana, blackBrush, 20, 250);
            page.Graphics.DrawString("Greek - Î”ÎµÎ¯Î³Î¼Î± ÎµÎ»Î»Î·Î½Î¹ÎºÏŒ ÎºÎµÎ¯Î¼ÎµÎ½Î¿ demo Î³ÏÎ±Î¼Î¼Î±Ï„Î¿ÏƒÎµÎ¹ÏÎ¬Ï‚.", unicodeVerdana, blackBrush, 20, 275);
        }

        private static void DisableTextCopy(PdfPage page, Stream ttfStream)
        {
            PdfStandardFont titleFont = new PdfStandardFont(PdfStandardFontFace.HelveticaBold, 22);
            PdfBrush blackBrush = new PdfBrush(new PdfRgbColor());

            page.Graphics.DrawString("Draw text that cannot be copied and", titleFont, blackBrush, 20, 50);
            page.Graphics.DrawString("pasted in another applications", titleFont, blackBrush, 20, 75);

            ttfStream.Position = 0;
            PdfUnicodeTrueTypeFont f1 = new PdfUnicodeTrueTypeFont(ttfStream, 16, true);
            page.Graphics.DrawString("This text can be copied and pasted", f1, blackBrush, 20, 150);
            page.Graphics.DrawString("Lorem ipsum dolor sit amet, consectetur adipiscing elit.", f1, blackBrush, 20, 175);

            ttfStream.Position = 0;
            PdfUnicodeTrueTypeFont f2 = new PdfUnicodeTrueTypeFont(ttfStream, 16, true);
            f2.EnableTextCopy = false;
            page.Graphics.DrawString("This text cannot be copied and pasted.", f2, blackBrush, 20, 225);
            page.Graphics.DrawString("Praesent sed massa a est fringilla mattis. Aenean sit amet odio ac nunc.", f2, blackBrush, 20, 250);
        }
}
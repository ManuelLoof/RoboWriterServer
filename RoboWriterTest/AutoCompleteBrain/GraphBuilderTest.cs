using Xunit;
using RoboWriter.AutoCompleteBrain; 

public class GraphBuilderTest
{
    [Fact]
    public void SetText()
    {
        var builder = new GraphBuilder();
        builder.SetText("Das ist mein aller erster Testsatz.");
    }

    [Fact]
    public void SetTextRockyBalboa()
    {
        var builder = new GraphBuilder();
        builder.SetText(
            "Es kommt im Leben nicht darauf an wie viel Du austeilst, sondern darauf wie viel Du einstecken kannst!" +
            "Es ist erst vorbei, wenn es vorbei ist! Ist das ein Spruch aus den achtzigern? Nein, eher aus den siebzigern." +
            "Ich werd dir jetzt was sagen, was du schon längst weißt... Die Welt besteht nicht nur aus Sonnenschein und Regenbogen. Sie ist oft ein gemeiner und hässlicher Ort. Und es ist ihr egal wie stark du bist - sie wird dich in die Knie zwingen und dich zermalmen, wenn du es zulässt... Du und ich - und auch sonst keiner - kann so hart zuschlagen wie das Leben ! Aber der Punkt ist nicht der, wie hart einer zuschlagen kann... Es zählt bloß, wieviele Schläge man einstecken kann und ob man trotzdem weitermacht. Wieviel man einstecken kann und trotzdem weitermacht.... Nur so gewinnt man ! Wenn du weißt was du wert bist , dann geh hin und hol es dir. Aber nur, wenn du bereit bist die Schläge dafür einzustecken ! Aber zeig nicht mit dem Finger auf andere und sag du bist nich da wo du hinwolltest, wegen ihm oder wegen ihr, oder sonst irgendjemandem. Schwächlinge tun das ! Und das bist Du nicht - DU bist besser!"
        );
    }

    [Fact]
    public void SetTextRambo()
    {
        var builder = new GraphBuilder();
        builder.SetText(
            "Nichts ist vorbei! Gar nichts! Ihr könnt nicht einfach aufhören. Es ist nicht mein Krieg gewesen! Ihr wolltet es so, ihr habt angefangen! Ich hab´ nur alles getan, um zu gewinnen, aber irgend jemand ließ uns nicht gewinnen. Als ich zurückkam in diese Welt, empfingen mich all diese Maden auf dem Flughafen! Sie haben gegen mich demonstriert und mich einen Babymörder und Frauenschänder genannt! Was haben die sich gedacht gegen mich zu demonstrieren, he, wer sind die denn? Niemand von ihnen war draußen in diesem Dschungel, sie wussten gar nicht, worum es geht! - Es war ´ne schlimme Zeit für alle, Rambo. Aber das ist jetzt vorbei. - Für sie! Mir bedeutet das Zivilleben gar nichts! Im Krieg, da hatten wir einen Ehrenkodex: Du deckst meinen Arsch, ich decke deinen! Aber hier gibt´s so was nicht! - Du bist der letzte deiner Elitetruppe. Du solltest es nicht so zu Ende führen! - Da drüben flog ich einen Hubschrauber, oder ich bin Panzer gefahren. Ich war verantwortlich für eine Million Dollar Ausrüstung und hier krieg´ ich nicht mal einen Job als Parkwächter!" +
            "Leider gibt es einen Toten, aber mich trifft keine Schuld!Lasst uns damit aufhören!" +
            "In Vietnam war es seine Aufgabe, Feinde umzubringen, zu töten, brutal, Sieg durch Zerstörung und Rambo war der Beste!"
     
        );
    }


}
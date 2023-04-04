# NotePad

**Az egyik diák javaslatára történt pár változtatás az órai anyaghoz képest. Bekerült egy Label ami mutatja, hogy éppen egy lementett fájlt szerkesztünk vagy pedig egy teljesen új fájlba dolgozunk. Azért, hogy ez fentre a menüpontok mellé kerüljün történt pár módosítás a felületen.**

 - A **MenüStrip** ***Dock property értéke: None*** de a bal felső sarokba helyezzük el a menüt.
 - A **RichTextBox** ***Dock property értéke: None***. Mivel a Dock át lett állítva Fill-ről None-ra, ezért nem fogja kitölteni a teljes területet, így kézzel ki kell húznunk a Form széléig és az **Anchor propery értéke: *Top, Bottom, Left, Right*** kell, hogy legyen. Ezt azért állítjuk be, hogy megmaradjon az a tulajdonság, hogy ha az ablak méretét változtatom, akkor a RichTextBox mérete is vele együtt változzon. 
 - A MenuStrip mellé bekerül egy Label elem aminek a **Name property értéke: *lbl_edited_file*** és ezen elem Text property-jét állítgatjuk a kódban annak megfelelően, hogy már létezik-e a fájl vagy sem. Ha létezik mert már lementettük, vagy ha egy korábbit nyitunk meg/ töltünk be, kiírjuk fentre, hogy éppen melyik fájlt szerkesztjük, ha pedig még nem létezik a fájl, akkor azt írjuk ki, hogy a felhasználó éppen egy teljesen új fájlt szerkeszt.

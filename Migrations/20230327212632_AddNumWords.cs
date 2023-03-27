using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArrestedDevelopmentApi.Migrations
{
    public partial class AddNumWords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfWords",
                table: "Quotes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 1,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 4, "Hair up, glasses off" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 2,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 7, "Unknown", "You boys know how to shovel coal?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 3,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 8, "Unknown", "What do you expect, Mother? I'm half machine!" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 4,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 3, "I'm a monster!" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 5,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 10, "It's a good thing he's already got that little scooter" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 6,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 8, "Unknown", "A heart attack never stopped old Big Bear" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 7,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 10, "I didn't even know we were calling him Big Bear" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 8,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 9, "You could charm the black off a telegram boy" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 9,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 6, "Unknown", "Did you see the new Poof?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 10,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 7, "I love all of my children equally" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 11,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 9, "No one's called him Baby Buster since high school" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 12,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 10, "They didn't sneak into this country to be your friends" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 13,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 9, "Unknown", "You were just a turd out there, you know?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 14,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 9, "This party is going to be off the hook" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 15,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 8, "Unknown", "I hear the jury's still out on science" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 16,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 7, "Unknown", "Like anyone would want to \"R\" her" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 17,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 11, "Can't a guy call his mother pretty without it seeming strange?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 18,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 10, "This is the best free scrapbooking class I've ever taken" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 19,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 5, "Unknown", "Go ahead, touch the Cornballer" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 20,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 11, "Unknown", "I'm going to run this through again on \"pots and pans\"" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 21,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 20, "Unknown", "I've been in the film business for a while but I just can't seem to get one in the can" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 22,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 16, "Unknown", "I will be a bigger and hairier mole than the one on your inner left thigh" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 23,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 15, "Unknown", "I want to cry so bad, but I don't think I can spare the moisture" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 24,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 7, "Maybe it was the other George Michael" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 25,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 11, "Unknown", "I'm tired of trying to find happiness through lies and self-medicating" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 26,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 12, "Unknown", "It's so watery, and yet there's a smack of ham to it" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 27,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 12, "The seal is for marksmanship, and the gorilla is for sand racing" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 28,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 13, "Unknown", "After all these years, God's not going to take a call from you" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 29,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 13, "Unknown", "You mean the guy we're meeting with can't even grow his own hair?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 30,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 9, "Unknown", "I thought the two of us could talk man-on-man" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 31,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 23, "I spent so much time making sweet love on my wife that it's hard to hear anything over the clatter of her breasts" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 32,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 5, "You've been warned about touching" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 33,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 2, "No touching" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 34,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 6, "Unknown", "I think I maced a crane" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 35,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 10, "Unknown", "Wine only turns to alcohol if you let it sit" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 36,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 11, "Unknown", "I see you've wasted no time in filling my seat hole" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 37,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 15, "Unknown", "I'm going to buy you the single healthiest call girl this town has ever seen" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 38,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 4, "Unknown", "Turn this skiff around" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 39,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 9, "Unknown", "I never thought I'd miss a hand so much" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 40,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 12, "Unknown", "I can just taste those meaty leading man parts in my mouth." });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 41,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 8, "Everyone's laughing and riding and cornholing except Buster" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 42,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 7, "Unknown", "You can always tell a Milford man" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 43,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 15, "Unknown", "Let me take off my assistant's skirt and put on my Barbra-Streisand-in-The-Prince-of-Tides ass-masking therapist pantsuit" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 44,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 9, "Unknown", "I don't want no part of yo tight-ass country-club" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 45,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 6, "Unknown", "Don't leave your Uncle T-Bag hanging" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 46,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 10, "Unknown", "What have we always said is the most important thing?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 47,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 8, "We're just blowing through nap time, aren't we?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 48,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 8, "Unknown", "Let me give that oatmeal some brown sugar" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 49,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 12, "Unknown", "A sea of waiters and no one will take a drink order" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 50,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 3, "Unknown", "Those are balls" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 51,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 11, "Unknown", "I'm gonna build me an airport, put my name on it" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 52,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 5, "Unknown", "Let me out that queen" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 53,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 6, "Unknown", "Do these effectively hide my thunder?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 54,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 21, "Unknown", "You just grab that brownish area by its points and you don't let go no matter what your mother tells you" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 55,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 7, "I guess you can say I'm buy-curious" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 56,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 7, "Unknown", "The soup of the day is bread" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 57,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 20, "Unknown", "I could use a leather jacket for when I'm on my hog and have to go into a controlled slide" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 58,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 8, "Unknown", "Are you at all concerned about an uprising?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 59,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 8, "Unknown", "In the dark, it all looks the same" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 60,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 15, "Look at us, crying like a bunch of girls on the last day of camp" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 61,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 12, "Unknown", "You just made a fool out of yourself in front of T-Bone" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 62,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 11, "I hope you also carry a spare bowl of candy beans" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 63,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 9, "Unknown", "You can't just comb that out and reset it?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 64,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 8, "Unknown", "Look what the homosexuals have done to me" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 65,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 18, "Unknown", "Everything they do is so dramatic and flamboyant, it just makes me want to set myself on fire" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 66,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 7, "Unknown", "I may have committed some light treason" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 67,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 11, "Unknown", "I don't understand the question and I won't respond to it" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 68,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 7, "Unknown", "There's always money in the banana stand" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 69,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 20, "Unknown", "In this business of show, you have to have the heart of an angel and the hyde of an elephant" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 70,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 18, "Unknown", "Too many lives have been ruined because some cheap waitress at a HoJo said she used an I.U.D." });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 71,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 12, "Unknown", "Do you think I could have a hit of that juice box?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 72,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 12, "Unknown", "Suddenly he's too much of a big shot to brush Mother's hair" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 73,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 5, "Unknown", "It walked on my pillow" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 74,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 4, "Unknown", "That's not a spinner" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 75,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 9, "Unknown", "I thought I saw a graham cracker out there" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 76,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 8, "Unknown", "There's still plenty of meat on that bone" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 77,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 15, "Unknown", "Now you take this home, throw it in a pot, add some broth, a potato" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 78,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 21, "Unknown", "You take this home, throw it in a pot, add some broth, a potato — baby, you got a stew going" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 79,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 6, "Unknown", "Never once touched my per diem" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 80,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 5, "Unknown", "Army had a half day" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 81,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 16, "The mere fact that you call making love \"pop pop\" tells me that you're not ready" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 82,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 17, "Unknown", "I'd have to get up pretty early in the morning to get drunk by 1 o' clock" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 83,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 5, "Unknown", "There are dozens of us" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 84,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 12, "Unknown", "I think you're going to be surprised at some of your phrasing" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 85,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 7, "Unknown", "Stop licking my hand, you horse's ass" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 86,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 6, "Unknown", "I'm afraid I just blue myself" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 87,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 12, "Why don't we just take an ad out in \"I'm Poor\" magazine?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 88,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 8, "And that's why you always leave a note" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 89,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 12, "It's not your fault your parents were cousins, but here we are" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 90,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 6, "Unknown", "You're going to get some hop-ons" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 91,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 13, "Unknown", "It just seems like there's still light coming in from under the door" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 92,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 6, "Unknown", "I'm leaving my mother for you" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 93,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 4, "Unknown", "You're replacing my mother" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 94,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 13, "Unknown", "Even if it means me taking a chubby, I will suck it up" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 95,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 12, "Unknown", "If she's not going to say anything, I certainly can't help her" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 96,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 4, "I hate this doctor" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 97,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 11, "Unknown", "That's like comparing apples and some fruit nobody's ever heard of" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 98,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 9, "Is that what's going to happen to my hair?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 99,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 7, "Finally, some good news from this guy" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 100,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 7, "There's no other way to take that" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 101,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 12, "Unknown", "He's lost his left hand, so he's going to be all right" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 103,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 5, "Unknown", "Don't call my escorts whores" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 104,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 5, "Unknown", "He's definitely got a type" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 105,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 5, "Unknown", "That's my son, you pothead" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 106,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 4, "God knows they're squinters" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 107,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 12, "Instead of making houses, maybe you should make land on the ocean" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 108,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 12, "Maybe you're not smart either. I didn't know until they told me" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 109,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 8, "Unknown", "I've opened a door here that I regret" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 110,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 8, "What's Spanish for \"I know you speak English\"?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 111,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 7, "Unknown", "You gave us cereal in an ashtray" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 112,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 4, "Unknown", "My name is Judge" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 113,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 10, "Unknown", "Why can't I have hair and money and him nothing?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 114,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 7, "Unknown", "There's the woman I'm sexually attracted to" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 115,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 5, "Unknown", "I was trained by Army" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 116,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 14, "Unknown", "I don't want to blame it all on 9/11, but it certainly didn't help" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 117,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 1, "Annyong" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 118,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 6, "Unknown", "Brand new cars don't get waxed" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 119,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 7, "Unknown", "Maybe I'll put it in her brownie" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 120,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 10, "You can sink your arrow into my buttocks any time" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 121,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 7, "Unknown", "I thought it was a pool toy" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 122,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 9, "Unknown", "I wouldn't mind kissing that man between the cheeks" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 124,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 9, "Unknown", "A trick is something a whore does for money" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 125,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 2, "Unknown", "Illusions, Michael" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 126,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 7, "Unknown", "Clearly the blue part is the land" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 127,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 6, "Unknown", "I don't know what I expected" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 128,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 1, "Unknown", "Huzzah!" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 129,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 4, "Unknown", "It's a wonderful restaurant" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 130,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 8, "Why are you squeezing me with your body?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 131,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 6, "He's going to be all right" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 132,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 7, "Unknown", "I was set up by the Brits" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 133,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 6, "Unknown", "Say something that will terrify me" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 134,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 13, "Unknown", "I'll buy you a hundred George Michaels that you can teach to drive" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 135,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 6, "Unknown", "I should be in this Poof" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 136,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 4, "Unknown", "Did somebody say Wonder?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 137,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 5, "She turns illusions for money" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 138,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 17, "Unknown", "Everything I've said about you can be covered with makeup and a lie about a thyroid problem" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 139,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 7, "He just wants to see boys' Linuses" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 140,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 9, "Half your testicle was hanging out of that thing" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 141,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 9, "Give me an old pro like a Robert Redford" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 142,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 5, "Unknown", "Give my son the juice" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 143,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 9, "Unknown", "You look like the window of a butcher shop" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 144,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 8, "Unknown", "You told me I wasn't fit to serve" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 145,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 6, "Unknown", "They even touched my Charlie Browns" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 146,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 4, "Unknown", "It's tired in here" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 147,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 7, "Unknown", "Make love in your own hand, mother" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 148,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 5, "Unknown", "Sometimes love should be terrifying" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 151,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 5, "Unknown", "It's just mom and whores" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 152,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 7, "Unknown", "Can't you keep my hand to yourself?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 153,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 6, "Unknown", "Have you seen my rubber hand?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 154,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 8, "Unknown", "I've always loved those leathery little snappy faces" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 155,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 3, "Unknown", "Soft and alive" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 156,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 8, "Unknown", "It wasn't really the pronunciation that bothered me" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 157,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 8, "My hook is stuck in the stair car" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 158,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 11, "And that's why you don't use one-armed persons to teach lessons" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 159,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 3, "Unknown", "He's a robot!" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 160,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 19, "Unknown", "If the only thing I could do was lay in bed all day and eat soup, I'd be happy" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 161,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 8, "I could just take it through a tube" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 162,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 4, "Never let me die" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 163,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 12, "Unknown", "When I miss your lips, I'll put a fig in my mouth" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 164,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 18, "Unknown", "My love thinks I'm a coward just because I wasted precious hospital resources to avoid my legal obligation" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 165,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 7, "I've always pictured him in a lighthouse" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 166,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 10, "Unknown", "I need to be rubbing elbows, not working your fork" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 167,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 7, "Unknown", "The ocean is my second biggest fear" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 168,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 29, "I hope that's not a crack about my hair color, lips, forehead, nose and teeth because at least I'm not the wearing a round sweater set on my face" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 169,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 5, "Unknown", "You're looking at balls here" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 170,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 4, "I've seen the blood" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 171,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 15, "Imagine the impact if that had come on right when we turned on the TV" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 172,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 4, "Unknown", "Cool your Japanese jets" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 173,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 6, "Unknown", "You forgot to say \"away\" again" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 174,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 7, "Unknown", "Look at the beak on that bird" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 175,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 12, "Unknown", "I think the name Michael is making you look for a man" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 176,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 5, "Unknown", "You can just say \"intercourse\"" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 177,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 4, "Unknown", "We just say \"manager\"" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 178,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 3, "Unknown", "Doesn't matter who" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 179,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 10, "Unknown", "I'd rather be dead in California than alive in Arizona" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 180,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 6, "I call it hot ham water" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 181,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 7, "Unknown", "He's a regular Freddie Wilson, that one" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 182,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 4, "Don't call it that" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 183,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 15, "Unknown", "If you didn't have adult onset diabetes, I wouldn't mind giving you a little sugar" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 184,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 9, "Unknown", "You don't want a hungry dove down your pants" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 185,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 7, "Unknown", "That's how Tony Wonder lost a nut" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 186,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 13, "Unknown", "Why go to a banana stand when we can make YOUR banana stand?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 187,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 11, "Unknown", "Don't worry, these young beauties have been nowhere near the bananas" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 188,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 12, "And that's why you don't try to teach lessons to your father" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 189,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 8, "Unknown", "We'll be the laughing stock of the boardwalk" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 190,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 11, "If you feel something moving down there, it's just the bird" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 191,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 11, "Unknown", "I might have you beaten with a pillowcase full of batteries" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 192,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 14, "Unknown", "The guy runs a prison; he can have any piece of ass he wants" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 193,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 6, "Unknown", "Who's the \"her\" in that sentence?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 194,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 5, "Please don't call yourself that" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 195,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 13, "Unknown", "I don't know why I always assume that everyone has read my screenplay" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 196,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 12, "Unknown", "I'm not going to spend this kind of money and not watch" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 197,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 6, "Unknown", "He showers her with club sauce" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 198,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 13, "You've never told me how many houses there are in the British Parliament" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 199,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 10, "Unknown", "I think we could be more than just gym buddies" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 200,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 5, "You're blowing my mind, Frank" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 201,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 5, "Unknown", "The whole backside has moles" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 202,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 5, "Unknown", "There's no \"I\" in \"win\"" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 203,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 5, "Within her lies a queen" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 204,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 8, "Unknown", "You can control your bladder when you're dead" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 205,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 12, "I ought to pull down your pants and spank your ass raw" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 206,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 12, "Unknown", "Why should you go to jail for a crime someone else noticed?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 207,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 11, "Unknown", "I was a professional twice over: an analyst and a therapist" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 208,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 4, "Unknown", "The world's first analrapist" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 209,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 9, "I shall drop you off alive, hooker or no" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 210,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 15, "Unknown", "They're polite and the men all sound gay, but they will rip out your heart" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 211,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 6, "Unknown", "I almost had Pop-Pop in Reno" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 212,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 11, "If this tableau I recreate, perhaps I can re-snare my mate" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 213,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 10, "Unknown", "I don't want anybody to go inside that musty claptrap" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 214,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 17, "Unknown", "We were both waiting for our dads at that garden where the little boy found the arm" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 215,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 12, "Unknown", "I kind of feel like that kid who found the severed hand" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 216,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 6, "Unknown", "I don't see you crying, robot" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 217,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 4, "Say goodbye to these" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 218,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 20, "I promised myself I wasn't going to become one of those people who were always going on about their screenplays" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 219,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 12, "Unknown", "Nobody sells any coke in this pen without daddy getting a taste" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 220,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 13, "Unknown", "You haven't seen a little box with a turtle on it, have you?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 221,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 14, "Unknown", "My turtle was living in it before he ate all the grass and died" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 222,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 5, "The scabs come right off" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 223,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 11, "Unknown", "I can't say no to the woman who gave me chlamydia" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 224,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 10, "Unknown", "People hear the name Tobias, they think big black guy" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 225,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 16, "Unknown", "I just don't want people's kids getting their sticky little fingers all over these $2,600 pants" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 226,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 25, "Unknown", "The guy who's dirty dancing with his niece is going to tell the guy in the $3,600 suit how to run the business. Come on" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 227,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 8, "Unknown", "Suddenly playing with yourself is a scholarly pursuit" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 228,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 14, "Unknown", "If I wanted something your thumb touched, I'd eat the inside of your ear" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 229,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 7, "Unknown", "You let him go in the sun?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 230,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 9, "Unknown", "Then why don't you marry an ice cream sandwich?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 231,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 24, "Unknown", "I will pack your sweet pink mouth with so much ice cream you'll be the envy of every Jerry and Jane on the block" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 232,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 11, "Unknown", "I am having a love affair with this ice cream sandwich" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 233,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 6, "Unknown", "Did you stick it to her?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 234,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 4, "Unknown", "Pop-Pop needs your hair" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 235,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 8, "At least he's in prison, not an urn" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 236,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 10, "You know the hair that no one's supposed to see?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 237,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 8, "Unknown", "Everyone put on white robes and outsmarted us" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 238,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 10, "We shan't be telling your mother about this, shan't we?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 239,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 8, "Unknown", "Now there's somebody who needs a good mother" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 240,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 7, "Unknown", "I'll leave when I'm good and ready" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 241,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 12, "I need one of those necklaces in the shape of a T" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 242,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 8, "Unknown", "There's a cream with real diamonds in it" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 243,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 5, "Unknown", "You, sir, are a mouthful" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 244,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 15, "Unknown", "If I can't find a horny immigrant by then, I don't deserve to stay here" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 245,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 17, "Unknown", "There's a man inside me, and only when he's finally out can I walk free of pain" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 246,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 32, "Unknown", "I'm afraid I prematurely shot my wad on what was supposed to be a \"dry run\", if you will, so now I'm afraid I have something of a mess on my hands" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 247,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 5, "Unknown", "I've made a huge mistake" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 248,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 16, "Unknown", "You are playing adults with fully-formed libidos, not two young men playing grab-ass in the shower" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 249,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 13, "Unknown", "I can't go on a million bike rides whenever you want me to" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 250,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 13, "Unknown", "The doctor said there were claw marks on the walls of her uterus" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 251,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 8, "Unknown", "It's like she gets off on being withholding" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 252,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 7, "Unknown", "Look who's ragging on the old lady" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 253,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 5, "Look at me, \"getting off\"" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 254,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 7, "Unknown", "I always ended up on all fours" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 255,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 4, "Unknown", "This kind of agility?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 256,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 17, "Unknown", "Do you see me more as the respected dramatic actor or more of the beloved comic actor?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 257,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 18, "Unknown", "I don't even want to tell you what she wouldn't let me do to her in the car" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 258,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 5, "Unknown", "I thought you had class" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 259,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 6, "Unknown", "Carl Weathers took everything from me" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 260,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 9, "Unknown", "You could have been sleeping with Frightened Inmate #2" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 261,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 6, "Unknown", "Some call me The Human Metronome" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 262,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 9, "So far it's been all chain and no ball" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 263,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 10, "Not everything is strippers and booze and buckets of blood" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 264,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 5, "Unknown", "You're out of the band" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 265,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 8, "Unknown", "I've already got a Lucille in my life" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 266,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 6, "Unknown", "Is this something society will allow?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 267,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 11, "Unknown", "I just jumped through a plate glass window on a date" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 268,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 6, "I have been Googling your father" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 269,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 8, "Unknown", "I sold you for a pack of cigarettes" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 270,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 4, "Unknown", "You don't fire crazy" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 271,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 5, "Unknown", "All these books are cooked" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 272,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 9, "Unknown", "It's like a mind puzzle, an awesome mind puzzle" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 273,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 6, "Unknown", "Talk you off of what, Pop-Pop?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 274,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 10, "Unknown", "Where once there was a yacht, now there is naught" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 275,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 5, "Unknown", "Who doesn't love the Jews?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 276,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 10, "Unknown", "I was going to smoke the marijuana like a cigarette" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 277,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 9, "Unknown", "They don't allow you to have bees in here" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 278,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 7, "Unknown", "I think something laid eggs on me" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 279,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 17, "Unknown", "Mother say no carbohydrate for you if you ever going to get girlfriend that's not old lady" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 280,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 12, "Unknown", "Maybe we should kiss again to teach them a lesson about obvious" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 281,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 5, "Look how he zips now" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 282,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 10, "Unknown", "I should have never taken the pumps out of here" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 283,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 16, "You just can't deal with the fact that I've got a super-thin wife with huge cans" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 284,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 18, "Did you know that you can get a refill on any drink you want here, and it's free?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 285,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 14, "Aren't you the sweetest thing, spending some time with what's left of your uncle" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 286,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 12, "He couldn't wait to swoop in and throw on the sailor suit" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 287,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 6, "Unknown", "I got children all over town" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 288,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 5, "My father is my uncle" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 289,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 9, "Unknown", "That's the kind of joke he would have loved" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 290,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 7, "Unknown", "Who'd like a banger in the mouth?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 291,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 6, "Unknown", "We just call it a sausage" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 292,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 10, "Unknown", "Franklin said some things Whitey just wasn't ready to hear" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 293,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 8, "I forgot that we were in the colonies" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 294,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 6, "Unknown", "Take me to your secular world" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 295,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 4, "Unknown", "My socks are wet" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 296,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 4, "Me quick, want slow" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 297,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 3, "Unknown", "Tea for dong!" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 298,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 10, "Unknown", "I'd want to get in there and find some answers" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 299,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 10, "Unknown", "Excuse me for liking the way they shape my junk" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 300,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 16, "It's not just going to be my love and George Michael's, but God's love as well" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 301,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 5, "Can it open a can?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 302,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 8, "A seal didn't bite your Linus off, right?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 303,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 8, "Unknown", "No, a seal didn't bite my Linus off" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 304,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 3, "Unknown", "Up yours, granny!" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 305,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 4, "Unknown", "You couldn't handle it!" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 306,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 13, "Unknown", "Seems like only yesterday you were bursting forth from your mother's fertile womb" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 307,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 12, "Unknown", "You don't see me nervous about being on my third Virgin Mary" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 308,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 24, "Unknown", "You are a worse psychiatrist than you are a son-in-law, and you will never get work as an actor because you have no talent" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 309,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 16, "Unknown", "I had no idea a ninety year-old man could cave in my chest cavity like that" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 310,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 8, "Unknown", "I think your knee is on my heart" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 311,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 19, "Unknown", "I'm afraid I prematurely shot my wad on what was supposed to be a dry run, if you will" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 312,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 14, "Unknown", "I'm going to see if I can get a wrench to strip my nuts" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 313,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 7, "Unknown", "I haven't had a massage since prison" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 314,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 3, "Unknown", "He's an alpaca" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 315,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 13, "Unknown", "One of this guy's eyebrows just fell in the bowl of candy beans" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 316,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 10, "Unknown", "I think George Michael is hiding Ann in the attic" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 317,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 9, "Unknown", "It's as Ann as the nose on Plain's face" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 318,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 6, "Unknown", "I have Pop-Pop in the attic" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 319,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 7, "Unknown", "Who wants to go to the hospital?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 320,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 9, "Unknown", "That was 100% inappropriate, and I do apologize profusely" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 321,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 17, "Unknown", "I ought to point to Uncle Oscar's Charlie Browns next time you're on top of him, Mother" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 322,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 17, "Unknown", "I figured if I blue myself early I'd be nice and relaxed for a 9:00 dinner reservation" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 323,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 14, "Unknown", "I can actually smear diamonds on my face, and it's only $400 a tub" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 324,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 5, "Unknown", "She calls it a 'mayon-egg'" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 325,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 14, "Unknown", "Mom volunteered me for the Army just because the fat man dared her to" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 326,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 5, "The tears just aren't coming" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 327,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 11, "Unknown", "You mean you can wear stripper clothes when you're not stripping?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 328,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 5, "Unknown", "You could hump that hood" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 329,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 7, "What a fun sexy time for you" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 330,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 8, "What I'm calling you is a television actor" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 331,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 14, "There's only one man I've ever called a coward, and that's Brian Doyle Murray" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 332,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 13, "Unknown", "We do not wag our genitals at one another to make a point" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 333,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 17, "Unknown", "It's a mainstay of the magician's toolkit, like how clowns always have a rag soaked in ether" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 334,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 16, "The worst that could happen is that I could spill coffee all over this $3,000 suit" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 335,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 7, "Unknown", "I came out of you, he didn't" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 336,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 9, "Unknown", "I liked it better when he just said Annyong" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 337,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 11, "Unknown", "Maybe it was the eleven months he spent in the womb" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 338,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 8, "Unknown", "You don't cry when you take those off?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 339,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 10, "Unknown", "How many times I gotta tell this kid chicken wings?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 340,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 5, "Unknown", "Somebody is a rude Gus" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 341,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 9, "Unknown", "I can't even fake the death of a stripper" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 342,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 7, "You didn't eat that dove, did you?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 343,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 14, "If someone had left a note, this innocent man would still have his arm" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 344,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 12, "Unknown", "You'd think a man locked up in prison would able to abstain" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 345,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 6, "Unknown", "Your father with his disgusting tweaking" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 346,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 12, "Unknown", "I couldn't breast feed any of you kids because of that man" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 347,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 15, "Unknown", "This is the nicest she's been since she found out that Rosa could breast-feed Buster" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 348,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 14, "Unknown", "First you dump all over it, now you want to know how it's done" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 349,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 9, "Unknown", "I feel like the prettiest girl at the dance" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 350,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 14, "Unknown", "I need to go take down the buffet and set up the leather pony" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 351,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 11, "Unknown", "They cannot arrest a husband and wife for the same crime" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 352,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 20, "Unknown", "Say what you want about America - thirteen bucks can still get you a hell of a lot of mice" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 353,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 6, "Unknown", "Who said anything bad about America?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 354,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 7, "Unknown", "So I'm thinking of getting a motorcycle" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 355,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 11, "Unknown", "Your legs look exactly like mine, and I just shaved mine" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 356,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 9, "Unknown", "I'm looking for something that says \"Dad likes leather\"" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 357,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 11, "Unknown", "You have to be some sort of she-hulk to get this" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 358,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 5, "Mom, you're ruining our fort" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 359,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 8, "Unknown", "Who'd want to mess with any of us?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 360,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 9, "Unknown", "Trying to introduce some edge to the whole palette" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 361,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 12, "Unknown", "Is she the one who's going to take him to the dentist?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 362,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 5, "You're right inside me now" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 363,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 11, "Unknown", "I can't believe they wouldn't even give me a wheelchair ride" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 364,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 10, "Unknown", "Doesn't this make you want to have an ice-cream cone?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 365,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 11, "Unknown", "I do believe there was some mention of some ice cream" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 366,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 9, "Unknown", "Does anyone know how to eat one of these?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 367,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 9, "There's a new daddy in town. A discipline daddy." });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 368,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 11, "Unknown", "I tried hitchhiking, but it's hard to do without a thumb" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 369,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 29, "Unknown", "Now what we do is we paint our lips Joan Crawford red, pop on a little blue eyeliner and then plant a lipstick kiss on every one of them" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 370,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 7, "Still, where'd the lighter fluid come from?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 371,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 5, "Unknown", "Larry, go to a mirror" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 372,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 7, "Why am I not going under water?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 373,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 17, "Unknown", "Why did I lose all the weight if they're going to put me in a pool cover?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 374,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 7, "Unknown", "I wish I could draw her nose" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 375,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 11, "Unknown", "I just found out that my cellular telephone was a lemon" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 376,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 8, "Are you wearing my dead wife's maternity clothes?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 377,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 6, "Unknown", "I can't get this ham open" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 378,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 16, "Unknown", "If he's got a shot with her, just give me a little tap on the fanny" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 379,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 15, "Unknown", "Now, when you do this without getting punched in the chest, you'll have more fun" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 380,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 14, "Unknown", "The Blue Man Group might need me, and I do deserve a fancy phone" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 381,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 12, "Unknown", "The doctor said I couldn't be a mother now if I tried" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 382,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 7, "I'm much, much, much older than 15" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 383,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 9, "And the worst part is he thinks he's passing" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 384,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 8, "Unknown", "Wow, that does sound like a little girl" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 385,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 7, "Unknown", "I'm going for a hot Ding Dong" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 386,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 6, "Unknown", "She said “tingling” like 75 times" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 387,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 6, "You smell like a pine cone" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 388,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 4, "Unknown", "I'm on bad mushrooms" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 389,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 7, "This close, they always look like landscape" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 390,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 5, "Unknown", "There were cutoffs up here?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 391,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 8, "Unknown", "What are you doing with Mother's rape horn?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 392,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 18, "Do you want to steer, or are you too old to sit on your pop's lap and drive?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 393,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 5, "Unknown", "They impounded my humble trailer" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 394,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 6, "Unknown", "Does this look contagious to you?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 395,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 7, "Unknown", "Nice to be back in a queen" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 396,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 5, "Unknown", "Let the great experiment begin" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 397,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 10, "Unknown", "There's got to be a better way to say that" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 398,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 8, "Unknown", "I am having the time of my life" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 399,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 4, "Unknown", "I haven't met Ann" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 400,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 9, "Unknown", "I kind of want to buy her a diamond" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 401,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 9, "Unknown", "I'm sure that Egg is a very nice person" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 402,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 4, "I heard zoo noises" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 403,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 6, "Unknown", "Which pinky do you use less?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 404,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 4, "Unknown", "Nothing on the inside" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 405,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 19, "Unknown", "I'm not proud of the way I was so grossed out when I found out you were gross before" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 406,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 15, "I'm just hoping to get mildly injured so I can get out of the Army" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 407,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 6, "I think my nipples are bleeding" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 408,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 3, "Unknown", "Flashes of Quincy" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 409,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 8, "I think the plant lady's wearing a thong" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 410,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 6, "Unknown", "Don't be such an Ann hog" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 411,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 5, "Go see a Star War" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 412,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 6, "Why am I not blacking out?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 413,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 5, "He swore by that Glisten" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 414,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 6, "Let's go dig up your uncle" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 415,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 20, "I will be head to toe in blue makeup until 8:01 in case the Blue Man Group needs their understudy" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 416,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 4, "Are we having yams?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 417,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 8, "First I blow him, then I poke him" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 418,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 13, "I don't think we need people trying to compete with what I'm wearing" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 419,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 8, "Unknown", "Don't ask me, I'm just the boy's father" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 420,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 14, "No one would believe that a woman like me would have a gay son" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 421,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 8, "I can see marinating a chicken in that" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 422,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 11, "Unknown", "Your Tweety Bird dance just cost us a run, you moron" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 423,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 12, "How do we filter out the teases? We don't let them in." });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 424,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 6, "I am stable as a table" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 425,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 19, "I would hardly call my mother a girl, but yes, she's still very much a part of my life" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 426,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 5, "Everybody thinks they're Frank Sinatra" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 427,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 5, "They make me feel dressier" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 428,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 7, "Unknown", "A piano could stand on those legs" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 429,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 6, "Guess she didn't see the drawings" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 430,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 9, "Unknown", "You have undone all of Dr. Sandor Plumb's work" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 431,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 16, "I need to prove to her that I'm not just a man, but a man's man" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 432,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 9, "Shall I put the Posturepedic in the down position?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 433,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 5, "Read me the appetizers again" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 434,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 10, "Unknown", "Did you have too much club sauce on your calamari?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 435,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 19, "Unknown", "I tried to drink some of the water, and it was too hot and it tasted like soy sauce" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 436,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 6, "Unknown", "I think the teriyaki chicken burst" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 437,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 9, "Unknown", "This isn't turning into the party hangout I hoped" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 438,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 7, "Unknown", "Stick a wrench in me, I'm done" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 439,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 7, "Unknown", "Someone order 140 pounds of upper-body strength?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 440,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 10, "Unknown", "It's just something the body does when you shake it" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 441,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 6, "Unknown", "Well, I'm all grown up now" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 442,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 8, "Unknown", "How'd you like to take a nap, baldy?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 443,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 7, "Unknown", "Let's not spin in the comfy chair" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 444,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 9, "Unknown", "I got Michael out of his marriage, didn't I?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 445,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 3, "I need macaroons" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 446,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 14, "You can win every argument like that, but that does not make you right" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 447,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 11, "I really hate it when you put on the God costume" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 448,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 6, "Unknown", "I'm cloaking myself in her scent" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 449,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 13, "Unknown", "I was made to understand that there would be grilled cheese sandwiches here" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 450,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 12, "Unknown", "Will someone please have the decency to punch me in the face?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 451,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 15, "Unknown", "Mom always taught us to curl up in a ball and remain motionless when confronted" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 453,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 4, "You old horny slut" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 454,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 5, "Unknown", "We all know you're Annyong" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 455,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 6, "Unknown", "No, Mother, I can blow myself" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 456,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 1, "Her?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 457,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 8, "Unknown", "She was made in a cup, like soup" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 458,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 9, "Oh, I'm sorry, I forgot: your wife is dead" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 459,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 26, "Unknown", "The one thing I will never do is not tell him that I'm taking him to a cabin in the woods and then not take him" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 460,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 5, "Unknown", "He was our miracle baby" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 461,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 7, "Unknown", "It's like my heart is getting hard" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 462,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 8, "I know what an erection feels like, Michael" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 463,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 4, "Unknown", "Those aren't even birds" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 464,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 3, "Unknown", "But I'm white" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 465,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 5, "Unknown", "It ain't easy being white" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 466,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 17, "I'm Mom and I want to shoot down everything you say so I feel good about myself" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 467,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 4, "Lets deal some drugs" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 468,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 7, "Unknown", "Why do you think I wear these?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 469,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 6, "A magician never reveals his secrets" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 470,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 5, "Unknown", "When's that voice gonna drop?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 471,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 5, "Unknown", "I'm gonna go get sexy" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 472,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 8, "Unknown", "They said he was some kind of scientist" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 473,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 5, "Unknown", "Speaking of settling, How's Ann?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 474,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 5, "Unknown", "It's hard to gauge time" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 475,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 6, "Unknown", "I like the way they think" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 476,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 8, "Unknown", "I was hoping he would be gifted sexually" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 477,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 15, "If this were a Lifetime Moment of Truth movie, this would be our act break" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 478,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 10, "Unknown", "A flower in my garden, a mystery in my panties" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 479,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 7, "I'm a scholar. I enjoy scholarly pursuits" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 480,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 6, "Unknown", "The warden could easily be black" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 481,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 8, "Unknown", "Who is this shiny building of a man?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 482,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 3, "Chickens don't clap" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 483,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 15, "I've got a stair car full of Mexican laborers that would love a day's work" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 484,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 3, "Are beads cheap?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 485,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 7, "Unknown", "We'll see who brings in more honey" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 486,
                columns: new[] { "NumberOfWords", "Text" },
                values: new object[] { 5, "He's thinking about bees again" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 487,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 22, "Unknown", "We're going to have to figure out something to do so that people can look at you without wanting to kill themselves" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 488,
                columns: new[] { "NumberOfWords", "Speaker", "Text" },
                values: new object[] { 9, "Unknown", "You don’t know a good bird hospital, do you?" });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "QuoteId", "NumberOfWords", "Speaker", "Text" },
                values: new object[,]
                {
                    { 102, 6, "Unknown", "Perhaps an attic shall I seek" },
                    { 123, 4, "Unknown", "Are those police boats?" },
                    { 149, 14, "Unknown", "My Army training tells me that this is going to be a hot mission" },
                    { 150, 4, "Unknown", "I don't date whores" },
                    { 452, 4, "Unknown", "We have unlimited juice?" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 452);

            migrationBuilder.DropColumn(
                name: "NumberOfWords",
                table: "Quotes");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 1,
                column: "Text",
                value: "You boys know how to shovel coal?");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 2,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "What do you expect, Mother? I'm half machine!" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 3,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "I'm a monster!" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 4,
                column: "Text",
                value: "It's a good thing he's already got that little scooter");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 5,
                column: "Text",
                value: "A heart attack never stopped old Big Bear");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 6,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "I didn't even know we were calling him Big Bear" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 7,
                column: "Text",
                value: "You could charm the black off a telegram boy");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 8,
                column: "Text",
                value: "Did you see the new Poof?");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 9,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Lucille", "I love all of my children equally" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 10,
                column: "Text",
                value: "No one's called him Baby Buster since high school");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 11,
                column: "Text",
                value: "They didn't sneak into this country to be your friends");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 12,
                column: "Text",
                value: "You were just a turd out there, you know?");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 13,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "This party is going to be off the hook" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 14,
                column: "Text",
                value: "I hear the jury's still out on science");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 15,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "Like anyone would want to \"R\" her" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 16,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "Can't a guy call his mother pretty without it seeming strange?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 17,
                column: "Text",
                value: "This is the best free scrapbooking class I've ever taken");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 18,
                column: "Text",
                value: "Go ahead, touch the Cornballer");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 19,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "I'm going to run this through again on \"pots and pans\"" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 20,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "I've been in the film business for a while but I just can't seem to get one in the can" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 21,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "I will be a bigger and hairier mole than the one on your inner left thigh" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 22,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Lucille", "I want to cry so bad, but I don't think I can spare the moisture" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 23,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GeorgeMichael", "Maybe it was the other George Michael" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 24,
                column: "Text",
                value: "I'm tired of trying to find happiness through lies and self-medicating");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 25,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Lindsay", "It's so watery, and yet there's a smack of ham to it" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 26,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "The seal is for marksmanship, and the gorilla is for sand racing" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 27,
                column: "Text",
                value: "After all these years, God's not going to take a call from you");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 28,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "You mean the guy we're meeting with can't even grow his own hair?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 29,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "I thought the two of us could talk man-on-man" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 30,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "I spent so much time making sweet love on my wife that it's hard to hear anything over the clatter of her breasts" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 31,
                column: "Text",
                value: "You've been warned about touching");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 32,
                column: "Text",
                value: "No touching");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 33,
                column: "Text",
                value: "I think I maced a crane");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 34,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Lindsay", "Wine only turns to alcohol if you let it sit" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 35,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "I see you've wasted no time in filling my seat hole" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 36,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "I'm going to buy you the single healthiest call girl this town has ever seen" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 37,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "Turn this skiff around" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 38,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "I never thought I'd miss a hand so much" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 39,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "I can just taste those meaty leading man parts in my mouth." });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 40,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Lucille", "Everyone's laughing and riding and cornholing except Buster" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 41,
                column: "Text",
                value: "You can always tell a Milford man");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 42,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "Let me take off my assistant's skirt and put on my Barbra-Streisand-in-The-Prince-of-Tides ass-masking therapist pantsuit" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 43,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Franklin", "I don't want no part of yo tight-ass country-club" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 44,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "Don't leave your Uncle T-Bag hanging" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 45,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Michael", "What have we always said is the most important thing?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 46,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "We're just blowing through nap time, aren't we?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 47,
                column: "Text",
                value: "Let me give that oatmeal some brown sugar");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 48,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Lucille", "A sea of waiters and no one will take a drink order" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 49,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Barry", "Those are balls" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 50,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "I'm gonna build me an airport, put my name on it" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 51,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "Let me out that queen" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 52,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "Do these effectively hide my thunder?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 53,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "You just grab that brownish area by its points and you don't let go no matter what your mother tells you" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 54,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "I guess you can say I'm buy-curious" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 55,
                column: "Text",
                value: "The soup of the day is bread");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 56,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GeorgeMichael", "I could use a leather jacket for when I'm on my hog and have to go into a controlled slide" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 57,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "Are you at all concerned about an uprising?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 58,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "In the dark, it all looks the same" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 59,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "Look at us, crying like a bunch of girls on the last day of camp" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 60,
                column: "Text",
                value: "You just made a fool out of yourself in front of T-Bone");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 61,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "I hope you also carry a spare bowl of candy beans" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 62,
                column: "Text",
                value: "You can't just comb that out and reset it?");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 63,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Lucille", "Look what the homosexuals have done to me" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 64,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Lucille", "Everything they do is so dramatic and flamboyant, it just makes me want to set myself on fire" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 65,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GeorgeSenior", "I may have committed some light treason" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 66,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Lucille", "I don't understand the question and I won't respond to it" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 67,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GeorgeSenior", "There's always money in the banana stand" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 68,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "In this business of show, you have to have the heart of an angel and the hyde of an elephant" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 69,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GeorgeSenior", "Too many lives have been ruined because some cheap waitress at a HoJo said she used an I.U.D." });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 70,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "Do you think I could have a hit of that juice box?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 71,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "Suddenly he's too much of a big shot to brush Mother's hair" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 72,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "It walked on my pillow" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 73,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Michael", "That's not a spinner" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 74,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "I thought I saw a graham cracker out there" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 75,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "CarlWeathers", "There's still plenty of meat on that bone" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 76,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "CarlWeathers", "Now you take this home, throw it in a pot, add some broth, a potato" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 77,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "CarlWeathers", "Baby, you got a stew going" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 78,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "CarlWeathers", "Never once touched my per diem" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 79,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "Army had a half day" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 80,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Michael", "The mere fact that you call making love \"pop pop\" tells me that you're not ready" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 81,
                column: "Text",
                value: "I'd have to get up pretty early in the morning to get drunk by 1 o' clock");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 82,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "There are dozens of us" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 83,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Michael", "I think you're going to be surprised at some of your phrasing" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 84,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GeorgeSenior", "Stop licking my hand, you horse's ass" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 85,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "I'm afraid I just blue myself" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 86,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Lindsay", "Why don't we just take an ad out in \"I'm Poor\" magazine?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 87,
                column: "Text",
                value: "And that's why you always leave a note");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 88,
                column: "Text",
                value: "It's not your fault your parents were cousins, but here we are");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 89,
                column: "Text",
                value: "You're going to get some hop-ons");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 90,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "It just seems like there's still light coming in from under the door" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 91,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "I'm leaving my mother for you" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 92,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "You're replacing my mother" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 93,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "Even if it means me taking a chubby, I will suck it up" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 94,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "If she's not going to say anything, I certainly can't help her" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 95,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Lucille", "I hate this doctor" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 96,
                column: "Text",
                value: "That's like comparing apples and some fruit nobody's ever heard of");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 97,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "SteveHolt", "Is that what's going to happen to my hair?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 98,
                column: "Text",
                value: "Finally, some good news from this guy");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 99,
                column: "Text",
                value: "There's no other way to take that");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 100,
                column: "Text",
                value: "He's lost his left hand, so he's going to be all right");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 101,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "Perhaps an attic shall I seek" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 103,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Michael", "He's definitely got a type" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 104,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "That's my son, you pothead" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 105,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "God knows they're squinters" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 106,
                column: "Text",
                value: "Instead of making houses, maybe you should make land on the ocean");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 107,
                column: "Text",
                value: "Maybe you're not smart either. I didn't know until they told me");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 108,
                column: "Text",
                value: "I've opened a door here that I regret");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 109,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "What's Spanish for \"I know you speak English\"?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 110,
                column: "Text",
                value: "You gave us cereal in an ashtray");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 111,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Franklin", "My name is Judge" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 112,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GeorgeSenior", "Why can't I have hair and money and him nothing?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 113,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "There's the woman I'm sexually attracted to" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 114,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "I was trained by Army" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 115,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "I don't want to blame it all on 9/11, but it certainly didn't help" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 116,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Annyong", "Annyong" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 117,
                column: "Text",
                value: "Brand new cars don't get waxed");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 118,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Oscar", "Maybe I'll put it in her brownie" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 119,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "You can sink your arrow into my buttocks any time" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 120,
                column: "Text",
                value: "I thought it was a pool toy");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 121,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "I wouldn't mind kissing that man between the cheeks" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 122,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "Are those police boats?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 124,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "Illusions, Michael" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 125,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "Clearly the blue part is the land" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 126,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Michael", "I don't know what I expected" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 127,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "Huzzah!" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 128,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "It's a wonderful restaurant" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 129,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Michael", "Why are you squeezing me with your body?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 130,
                column: "Text",
                value: "He's going to be all right");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 131,
                column: "Text",
                value: "I was set up by the Brits");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 132,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "Say something that will terrify me" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 133,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "I'll buy you a hundred George Michaels that you can teach to drive" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 134,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "I should be in this Poof" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 135,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "TonyWonder", "Did somebody say Wonder?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 136,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "She turns illusions for money" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 137,
                column: "Text",
                value: "Everything I've said about you can be covered with makeup and a lie about a thyroid problem");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 138,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "He just wants to see boys' Linuses" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 139,
                column: "Text",
                value: "Half your testicle was hanging out of that thing");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 140,
                column: "Text",
                value: "Give me an old pro like a Robert Redford");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 141,
                column: "Text",
                value: "Give my son the juice");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 142,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Lucille", "You look like the window of a butcher shop" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 143,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "You told me I wasn't fit to serve" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 144,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "They even touched my Charlie Browns" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 145,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "It's tired in here" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 146,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "Make love in your own hand, mother" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 147,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "Sometimes love should be terrifying" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 148,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "My Army training tells me that this is going to be a hot mission" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 151,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "Can't you keep my hand to yourself?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 152,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "Have you seen my rubber hand?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 153,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "I've always loved those leathery little snappy faces" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 154,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "Soft and alive" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 155,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Michael", "It wasn't really the pronunciation that bothered me" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 156,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "My hook is stuck in the stair car" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 157,
                column: "Text",
                value: "And that's why you don't use one-armed persons to teach lessons");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 158,
                column: "Text",
                value: "He's a robot!");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 159,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "If the only thing I could do was lay in bed all day and eat soup, I'd be happy" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 160,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "I could just take it through a tube" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 161,
                column: "Text",
                value: "Never let me die");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 162,
                column: "Text",
                value: "When I miss your lips, I'll put a fig in my mouth");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 163,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "My love thinks I'm a coward just because I wasted precious hospital resources to avoid my legal obligation" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 164,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "I've always pictured him in a lighthouse" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 165,
                column: "Text",
                value: "I need to be rubbing elbows, not working your fork");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 166,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "The ocean is my second biggest fear" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 167,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Lindsay", "I hope that's not a crack about my hair color, lips, forehead, nose and teeth because at least I'm not the wearing a round sweater set on my face" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 168,
                column: "Text",
                value: "You're looking at balls here");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 169,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GeorgeMichael", "I've seen the blood" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 170,
                column: "Text",
                value: "Imagine the impact if that had come on right when we turned on the TV");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 171,
                column: "Text",
                value: "Cool your Japanese jets");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 172,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Michael", "You forgot to say \"away\" again" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 173,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "Look at the beak on that bird" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 174,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "I think the name Michael is making you look for a man" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 175,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Michael", "You can just say \"intercourse\"" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 176,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Michael", "We just say \"manager\"" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 177,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Michael", "Doesn't matter who" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 178,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Lucille", "I'd rather be dead in California than alive in Arizona" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 179,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Lindsay", "I call it hot ham water" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 180,
                column: "Text",
                value: "He's a regular Freddie Wilson, that one");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 181,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Michael", "Don't call it that" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 182,
                column: "Text",
                value: "If you didn't have adult onset diabetes, I wouldn't mind giving you a little sugar");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 183,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "You don't want a hungry dove down your pants" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 184,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "That's how Tony Wonder lost a nut" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 185,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "Why go to a banana stand when we can make YOUR banana stand?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 186,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "Don't worry, these young beauties have been nowhere near the bananas" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 187,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GeorgeSenior", "And that's why you don't try to teach lessons to your father" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 188,
                column: "Text",
                value: "We'll be the laughing stock of the boardwalk");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 189,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "If you feel something moving down there, it's just the bird" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 190,
                column: "Text",
                value: "I might have you beaten with a pillowcase full of batteries");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 191,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "The guy runs a prison; he can have any piece of ass he wants" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 192,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Michael", "Who's the \"her\" in that sentence?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 193,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Michael", "Please don't call yourself that" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 194,
                column: "Text",
                value: "I don't know why I always assume that everyone has read my screenplay");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 195,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "I'm not going to spend this kind of money and not watch" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 196,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "He showers her with club sauce" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 197,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Michael", "You've never told me how many houses there are in the British Parliament" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 198,
                column: "Text",
                value: "I think we could be more than just gym buddies");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 199,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "You're blowing my mind, Frank" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 200,
                column: "Text",
                value: "The whole backside has moles");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 201,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "There's no \"I\" in \"win\"" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 202,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "Within her lies a queen" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 203,
                column: "Text",
                value: "You can control your bladder when you're dead");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 204,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "I ought to pull down your pants and spank your ass raw" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 205,
                column: "Text",
                value: "Why should you go to jail for a crime someone else noticed?");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 206,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "I was a professional twice over: an analyst and a therapist" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 207,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "The world's first analrapist" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 208,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Michael", "I shall drop you off alive, hooker or no" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 209,
                column: "Text",
                value: "They're polite and the men all sound gay, but they will rip out your heart");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 210,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Michael", "I almost had Pop-Pop in Reno" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 211,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "If this tableau I recreate, perhaps I can re-snare my mate" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 212,
                column: "Text",
                value: "I don't want anybody to go inside that musty claptrap");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 213,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "We were both waiting for our dads at that garden where the little boy found the arm" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 214,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "I kind of feel like that kid who found the severed hand" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 215,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "I don't see you crying, robot" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 216,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Kitty", "Say goodbye to these" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 217,
                column: "Text",
                value: "I promised myself I wasn't going to become one of those people who were always going on about their screenplays");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 218,
                column: "Text",
                value: "Nobody sells any coke in this pen without daddy getting a taste");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 219,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Oscar", "You haven't seen a little box with a turtle on it, have you?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 220,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "My turtle was living in it before he ate all the grass and died" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 221,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "The scabs come right off" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 222,
                column: "Text",
                value: "I can't say no to the woman who gave me chlamydia");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 223,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "People hear the name Tobias, they think big black guy" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 224,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "I just don't want people's kids getting their sticky little fingers all over these $2,600 pants" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 225,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "The guy who's dirty dancing with his niece is going to tell the guy in the $3,600 suit how to run the business. Come on" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 226,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Lucille", "Suddenly playing with yourself is a scholarly pursuit" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 227,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Lucille", "If I wanted something your thumb touched, I'd eat the inside of your ear" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 228,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Lucille", "You let him go in the sun?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 229,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Lucille", "Then why don't you marry an ice cream sandwich?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 230,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "I will pack your sweet pink mouth with so much ice cream you'll be the envy of every Jerry and Jane on the block" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 231,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GeorgeSenior", "I am having a love affair with this ice cream sandwich" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 232,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GeorgeSenior", "Did you stick it to her?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 233,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GeorgeSenior", "Pop-Pop needs your hair" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 234,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Lucille", "At least he's in prison, not an urn" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 235,
                column: "Text",
                value: "You know the hair that no one's supposed to see?");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 236,
                column: "Text",
                value: "Everyone put on white robes and outsmarted us");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 237,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "We shan't be telling your mother about this, shan't we?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 238,
                column: "Text",
                value: "Now there's somebody who needs a good mother");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 239,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Lucille", "I'll leave when I'm good and ready" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 240,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Maeby", "I need one of those necklaces in the shape of a T" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 241,
                column: "Text",
                value: "There's a cream with real diamonds in it");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 242,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "You, sir, are a mouthful" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 243,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "If I can't find a horny immigrant by then, I don't deserve to stay here" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 244,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "There's a man inside me, and only when he's finally out can I walk free of pain" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 245,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "I'm afraid I prematurely shot my wad on what was supposed to be a \"dry run\", if you will, so now I'm afraid I have something of a mess on my hands" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 246,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "I've made a huge mistake" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 247,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "You are playing adults with fully-formed libidos, not two young men playing grab-ass in the shower" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 248,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GeorgeMichael", "I can't go on a million bike rides whenever you want me to" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 249,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GeorgeSenior", "The doctor said there were claw marks on the walls of her uterus" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 250,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "It's like she gets off on being withholding" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 251,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "Look who's ragging on the old lady" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 252,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Lucille", "Look at me, \"getting off\"" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 253,
                column: "Text",
                value: "I always ended up on all fours");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 254,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "This kind of agility?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 255,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "Do you see me more as the respected dramatic actor or more of the beloved comic actor?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 256,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "I don't even want to tell you what she wouldn't let me do to her in the car" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 257,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "I thought you had class" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 258,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "Carl Weathers took everything from me" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 259,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "You could have been sleeping with Frightened Inmate #2" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 260,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GeorgeMichael", "Some call me The Human Metronome" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 261,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "So far it's been all chain and no ball" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 262,
                column: "Text",
                value: "Not everything is strippers and booze and buckets of blood");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 263,
                column: "Text",
                value: "You're out of the band");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 264,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "I've already got a Lucille in my life" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 265,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "Is this something society will allow?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 266,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "I just jumped through a plate glass window on a date" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 267,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Kitty", "I have been Googling your father" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 268,
                column: "Text",
                value: "I sold you for a pack of cigarettes");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 269,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GeorgeSenior", "You don't fire crazy" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 270,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GeorgeSenior", "All these books are cooked" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 271,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GeorgeMichael", "It's like a mind puzzle, an awesome mind puzzle" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 272,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GeorgeMichael", "Talk you off of what, Pop-Pop?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 273,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "Where once there was a yacht, now there is naught" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 274,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "Who doesn't love the Jews?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 275,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GeorgeMichael", "I was going to smoke the marijuana like a cigarette" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 276,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Michael", "They don't allow you to have bees in here" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 277,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Barry", "I think something laid eggs on me" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 278,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Annyong", "Mother say no carbohydrate for you if you ever going to get girlfriend that's not old lady" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 279,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Annyong", "Maybe we should kiss again to teach them a lesson about obvious" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 280,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Lucille", "Look how he zips now" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 281,
                column: "Text",
                value: "I should have never taken the pumps out of here");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 282,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "You just can't deal with the fact that I've got a super-thin wife with huge cans" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 283,
                column: "Text",
                value: "Did you know that you can get a refill on any drink you want here, and it's free?");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 284,
                column: "Text",
                value: "Aren't you the sweetest thing, spending some time with what's left of your uncle");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 285,
                column: "Text",
                value: "He couldn't wait to swoop in and throw on the sailor suit");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 286,
                column: "Text",
                value: "I got children all over town");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 287,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "My father is my uncle" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 288,
                column: "Text",
                value: "That's the kind of joke he would have loved");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 289,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "Who'd like a banger in the mouth?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 290,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Michael", "We just call it a sausage" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 291,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "Franklin said some things Whitey just wasn't ready to hear" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 292,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "I forgot that we were in the colonies" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 293,
                column: "Text",
                value: "Take me to your secular world");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 294,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "My socks are wet" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 295,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "Me quick, want slow" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 296,
                column: "Text",
                value: "Tea for dong!");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 297,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "I'd want to get in there and find some answers" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 298,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "Excuse me for liking the way they shape my junk" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 299,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Ann", "It's not just going to be my love and George Michael's, but God's love as well" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 300,
                column: "Text",
                value: "Can it open a can?");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 301,
                column: "Text",
                value: "A seal didn't bite your Linus off, right?");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 302,
                column: "Text",
                value: "No, a seal didn't bite my Linus off");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 303,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GeorgeSenior", "Up yours, granny!" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 304,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Lucille", "You couldn't handle it!" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 305,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "Seems like only yesterday you were bursting forth from your mother's fertile womb" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 306,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Maeby", "You don't see me nervous about being on my third Virgin Mary" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 307,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Lucille", "You are a worse psychiatrist than you are a son-in-law, and you will never get work as an actor because you have no talent" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 308,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "I had no idea a ninety year-old man could cave in my chest cavity like that" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 309,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "I think your knee is on my heart" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 310,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "I'm afraid I prematurely shot my wad on what was supposed to be a dry run, if you will" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 311,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Lucille", "I'm going to see if I can get a wrench to strip my nuts" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 312,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GeorgeSenior", "I haven't had a massage since prison" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 313,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Lucille", "He's an alpaca" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 314,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "One of this guy's eyebrows just fell in the bowl of candy beans" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 315,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Michael", "I think George Michael is hiding Ann in the attic" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 316,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Michael", "It's as Ann as the nose on Plain's face" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 317,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GeorgeMichael", "I have Pop-Pop in the attic" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 318,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "Who wants to go to the hospital?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 319,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "That was 100% inappropriate, and I do apologize profusely" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 320,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "I ought to point to Uncle Oscar's Charlie Browns next time you're on top of him, Mother" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 321,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "I figured if I blue myself early I'd be nice and relaxed for a 9:00 dinner reservation" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 322,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Lindsay", "I can actually smear diamonds on my face, and it's only $400 a tub" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 323,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GeorgeMichael", "She calls it a 'mayon-egg'" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 324,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "Mom volunteered me for the Army just because the fat man dared her to" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 325,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "The tears just aren't coming" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 326,
                column: "Text",
                value: "You mean you can wear stripper clothes when you're not stripping?");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 327,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GeorgeSenior", "You could hump that hood" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 328,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GeorgeMichael", "What a fun sexy time for you" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 329,
                column: "Text",
                value: "What I'm calling you is a television actor");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 330,
                column: "Text",
                value: "There's only one man I've ever called a coward, and that's Brian Doyle Murray");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 331,
                column: "Text",
                value: "We do not wag our genitals at one another to make a point");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 332,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "It's a mainstay of the magician's toolkit, like how clowns always have a rag soaked in ether" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 333,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "The worst that could happen is that I could spill coffee all over this $3,000 suit" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 334,
                column: "Text",
                value: "I came out of you, he didn't");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 335,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Michael", "I liked it better when he just said Annyong" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 336,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GeorgeSenior", "Maybe it was the eleven months he spent in the womb" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 337,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "You dont cry when you take those off?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 338,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GeorgeSenior", "How many times I gotta tell this kid chicken wings?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 339,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "Somebody is a rude Gus" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 340,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "I can't even fake the death of a stripper" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 341,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "You didn't eat that dove, did you?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 342,
                column: "Text",
                value: "If someone had left a note, this innocent man would still have his arm");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 343,
                column: "Text",
                value: "You'd think a man locked up in prison would able to abstain");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 344,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Lucille", "Your father with his disgusting tweaking" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 345,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Lucille", "I couldn't breast feed any of you kids because of that man" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 346,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Michael", "This is the nicest she's been since she found out that Rosa could breast-feed Buster" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 347,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "First you dump all over it, now you want to know how it's done" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 348,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "I feel like the prettiest girl at the dance" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 349,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "I need to go take down the buffet and set up the leather pony" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 350,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GeorgeSenior", "They cannot arrest a husband and wife for the same crime" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 351,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GeorgeMichael", "Say what you want about America - thirteen bucks can still get you a hell of a lot of mice" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 352,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "Who said anything bad about America?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 353,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GeorgeMichael", "So I'm thinking of getting a motorcycle" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 354,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Maeby", "Your legs look exactly like mine, and I just shaved mine" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 355,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "I'm looking for something that says \"Dad likes leather\"" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 356,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "You have to be some sort of she-hulk to get this" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 357,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "Mom, you're ruining our fort" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 358,
                column: "Text",
                value: "Who'd want to mess with any of us?");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 359,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GeorgeMichael", "Trying to introduce some edge to the whole palette" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 360,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Lucille", "Is she the one who's going to take him to the dentist?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 361,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "UncleJack", "You're right inside me now" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 362,
                column: "Text",
                value: "I can't believe they wouldn't even give me a wheelchair ride");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 363,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "Doesn't this make you want to have an ice-cream cone?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 364,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "I do believe there was some mention of some ice cream" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 365,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "Does anyone know how to eat one of these?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 366,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "There's a new daddy in town. A discipline daddy." });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 367,
                column: "Text",
                value: "I tried hitchhiking, but it's hard to do without a thumb");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 368,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "Now what we do is we paint our lips Joan Crawford red, pop on a little blue eyeliner and then plant a lipstick kiss on every one of them" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 369,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "Still, where'd the lighter fluid come from?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 370,
                column: "Text",
                value: "Larry, go to a mirror");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 371,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "Why am I not going under water?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 372,
                column: "Text",
                value: "Why did I lose all the weight if they're going to put me in a pool cover?");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 373,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GeorgeMichael", "I wish I could draw her nose" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 374,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "I just found out that my cellular telephone was a lemon" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 375,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Michael", "Are you wearing my dead wife's maternity clothes?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 376,
                column: "Text",
                value: "I can't get this ham open");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 377,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "If he's got a shot with her, just give me a little tap on the fanny" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 378,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "Now, when you do this without getting punched in the chest, you'll have more fun" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 379,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "The Blue Man Group might need me, and I do deserve a fancy phone" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 380,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Lucille", "The doctor said I couldn't be a mother now if I tried" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 381,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Lindsay", "I'm much, much, much older than 15" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 382,
                column: "Text",
                value: "And the worst part is he thinks he's passing");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 383,
                column: "Text",
                value: "Wow, that does sound like a little girl");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 384,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Barry", "I'm going for a hot Ding Dong" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 385,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Lindsay", "She said “tingling” like 75 times" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 386,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Lucille", "You smell like a pine cone" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 387,
                column: "Text",
                value: "I'm on bad mushrooms");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 388,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Barry", "This close, they always look like landscape" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 389,
                column: "Text",
                value: "There were cutoffs up here?");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 390,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Lucille", "What are you doing with Mother's rape horn?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 391,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Michael", "Do you want to steer, or are you too old to sit on your pop's lap and drive?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 392,
                column: "Text",
                value: "They impounded my humble trailer");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 393,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Barry", "Does this look contagious to you?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 394,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "Nice to be back in a queen" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 395,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "Let the great experiment begin" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 396,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Michael", "There's got to be a better way to say that" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 397,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GeorgeSenior", "I am having the time of my life" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 398,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Michael", "I haven't met Ann" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 399,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GeorgeMichael", "I kind of want to buy her a diamond" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 400,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Michael", "I'm sure that Egg is a very nice person" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 401,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "I heard zoo noises" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 402,
                column: "Text",
                value: "Which pinky do you use less?");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 403,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "Nothing on the inside" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 404,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Lindsay", "I'm not proud of the way I was so grossed out when I found out you were gross before" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 405,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "I'm just hoping to get mildly injured so I can get out of the Army" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 406,
                column: "Text",
                value: "I think my nipples are bleeding");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 407,
                column: "Text",
                value: "Flashes of Quincy");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 408,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "I think the plant lady's wearing a thong" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 409,
                column: "Text",
                value: "Don't be such an Ann hog");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 410,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Lucille", "Go see a Star War" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 411,
                column: "Text",
                value: "Why am I not blacking out?");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 412,
                column: "Text",
                value: "He swore by that Glisten");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 413,
                column: "Text",
                value: "Let's go dig up your uncle");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 414,
                column: "Text",
                value: "I will be head to toe in blue makeup until 8:01 in case the Blue Man Group needs their understudy");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 415,
                column: "Text",
                value: "Are we having yams?");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 416,
                column: "Text",
                value: "First I blow him, then I poke him");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 417,
                column: "Text",
                value: "I don't think we need people trying to compete with what I'm wearing");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 418,
                column: "Text",
                value: "Don't ask me, I'm just the boy's father");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 419,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Lucille", "No one would believe that a woman like me would have a gay son" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 420,
                column: "Text",
                value: "I can see marinating a chicken in that");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 421,
                column: "Text",
                value: "Your Tweety Bird dance just cost us a run, you moron");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 422,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "How do we filter out the teases? We don't let them in." });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 423,
                column: "Text",
                value: "I am stable as a table");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 424,
                column: "Text",
                value: "I would hardly call my mother a girl, but yes, she's still very much a part of my life");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 425,
                column: "Text",
                value: "Everybody thinks they're Frank Sinatra");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 426,
                column: "Text",
                value: "They make me feel dressier");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 427,
                column: "Text",
                value: "A piano could stand on those legs");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 428,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GeorgeMichael", "Guess she didn't see the drawings" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 429,
                column: "Text",
                value: "You have undone all of Dr. Sandor Plumb's work");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 430,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "I need to prove to her that I'm not just a man, but a man's man" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 431,
                column: "Text",
                value: "Shall I put the Posturepedic in the down position?");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 432,
                column: "Text",
                value: "Read me the appetizers again");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 433,
                column: "Text",
                value: "Did you have too much club sauce on your calamari?");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 434,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GeorgeSenior", "I tried to drink some of the water, and it was too hot and it tasted like soy sauce" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 435,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GeorgeSenior", "I think the teriyaki chicken burst" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 436,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GeorgeSenior", "This isn't turning into the party hangout I hoped" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 437,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Lindsay", "Stick a wrench in me, I'm done" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 438,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "UncleJack", "Someone order 140 pounds of upper-body strength?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 439,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "UncleJack", "It's just something the body does when you shake it" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 440,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Maeby", "Well, I'm all grown up now" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 441,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "UncleJack", "How'd you like to take a nap, baldy?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 442,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Michael", "Let's not spin in the comfy chair" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 443,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Barry", "I got Michael out of his marriage, didn't I?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 444,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Barry", "I need macaroons" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 445,
                column: "Text",
                value: "You can win every argument like that, but that does not make you right");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 446,
                column: "Text",
                value: "I really hate it when you put on the God costume");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 447,
                column: "Text",
                value: "I'm cloaking myself in her scent");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 448,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "I was made to understand that there would be grilled cheese sandwiches here" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 449,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "Will someone please have the decency to punch me in the face?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 450,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "Mom always taught us to curl up in a ball and remain motionless when confronted" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 451,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "We have unlimited juice?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 453,
                column: "Text",
                value: "We all know you're Annyong");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 454,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "No, Mother, I can blow myself" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 455,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Michael", "Her?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 456,
                column: "Text",
                value: "She was made in a cup, like soup");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 457,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "Oh, I'm sorry, I forgot: your wife is dead" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 458,
                column: "Text",
                value: "The one thing I will never do is not tell him that I'm taking him to a cabin in the woods and then not take him");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 459,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GeorgeSenior", "He was our miracle baby" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 460,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "It's like my heart is getting hard" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 461,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "I know what an erection feels like, Michael" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 462,
                column: "Text",
                value: "Those aren't even birds");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 463,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "But I'm white" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 464,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "It ain't easy being white" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 465,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "I'm Mom and I want to shoot down everything you say so I feel good about myself" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 466,
                column: "Text",
                value: "Lets deal some drugs");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 467,
                column: "Text",
                value: "Why do you think I wear these?");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 468,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "A magician never reveals his secrets" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 469,
                column: "Text",
                value: "When's that voice gonna drop?");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 470,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Maeby", "I'm gonna go get sexy" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 471,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Lucille", "They said he was some kind of scientist" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 472,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Michael", "Speaking of settling, How's Ann?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 473,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GeorgeSenior", "It's hard to gauge time" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 474,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GeorgeMichael", "I like the way they think" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 475,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GeorgeMichael", "I was hoping he would be gifted sexually" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 476,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "If this were a Lifetime Moment of Truth movie, this would be our act break" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 477,
                column: "Text",
                value: "A flower in my garden, a mystery in my panties");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 478,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "I'm a scholar. I enjoy scholarly pursuits" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 479,
                column: "Text",
                value: "The warden could easily be black");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 480,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Tobias", "Who is this shiny building of a man?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 481,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Buster", "Chickens don't clap" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 482,
                column: "Text",
                value: "I've got a stair car full of Mexican laborers that would love a day's work");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 483,
                column: "Text",
                value: "Are beads cheap?");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 484,
                column: "Text",
                value: "We'll see who brings in more honey");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 485,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "Michael", "He's thinking about bees again" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 486,
                column: "Text",
                value: "We're going to have to figure out something to do so that people can look at you without wanting to kill themselves");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 487,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "You don’t know a good bird hospital, do you?" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 488,
                columns: new[] { "Speaker", "Text" },
                values: new object[] { "GOB", "Hair up, glasses off" });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jester.Migrations
{
    public partial class UpdateContent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Story",
                table: "NewsItems",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatePublished", "Story" },
                values: new object[] { new DateTime(2024, 5, 23, 13, 18, 50, 773, DateTimeKind.Utc).AddTicks(8618), "<p>In a sleepy suburban neighborhood, where the most exciting event was usually the annual garden gnome competition, an unassuming man named Walter stumbled upon a phenomenon that would rewrite the laws of physics. Walter, a retired librarian with a penchant for mismatched socks, was merely trying to take his dog, Mr. Fluffington, for a routine evening walk.</p><p>As Walter clipped the leash onto Mr. Fluffington&rsquo;s collar, he felt a sudden tingle&mdash;a sensation akin to licking a battery. The world around him blurred, and before he could say &ldquo;fetch,&rdquo; he found himself standing in what appeared to be a parallel universe.</p><p>In this bizarre alternate reality, dogs walked humans. Yes, you read that correctly. Mr. Fluffington, now wearing a tiny leash, confidently led Walter through a bustling cityscape. Canine pedestrians nodded politely at their human counterparts, while fire hydrants served as communal bulletin boards covered in paw-print graffiti.</p><p>Experts from the Institute of Quantum Quirkiness are baffled by Walter&rsquo;s accidental discovery. They speculate that his mismatched socks acted as a quantum entanglement catalyst, propelling him into a dimension where the laws of pet ownership were delightfully reversed. As for Mr. Fluffington, he remains tight-lipped&mdash;perhaps guarding the secrets of interdimensional dog-walking.</p><p>Walter&rsquo;s advice to fellow dog owners? &ldquo;Always wear odd socks. You never know where they might take you.&rdquo;</p>" });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatePublished", "Story" },
                values: new object[] { new DateTime(2024, 5, 23, 13, 18, 50, 773, DateTimeKind.Utc).AddTicks(8880), "<p>A group of disgruntled vegetables gathered today in the heart of the farmers&rsquo; market to protest the &ldquo;unfair treatment&rdquo; of salads. Carrots, lettuce, and bell peppers held tiny picket signs that read, &ldquo;We Are More Than Just a Side Dish!&rdquo; Their leafy spokesperson, an emotional carrot named Carrotopia, addressed the crowd.</p><p>&ldquo;For too long, we&rsquo;ve been chopped, diced, and tossed aside without proper recognition,&rdquo; Carrotopia declared. &ldquo;We demand better representation on dinner plates!&rdquo;</p><p>The protesters demanded that salads be given equal billing alongside main courses. They proposed a &ldquo;Veggie Rights Act&rdquo; that would ensure fair treatment in restaurants and home kitchens alike. As part of their demands, they called for more creative salad dressings, celebrity endorsements (imagine Beyonc&eacute; endorsing arugula!), and a dedicated vegetable emoji.</p><p>Salad enthusiasts and carnivores alike watched in awe as the vegetable rally unfolded. Even the nearby fruit stand joined in solidarity, with bananas and apples nodding in agreement. The tomato, however, remained neutral&mdash;too busy straddling the line between fruit and vegetable.</p><p>As the sun set over the protest, Carrotopia raised a celery stalk high and shouted, &ldquo;Lettuce be heard!&rdquo; The crowd erupted in applause, and the movement gained momentum.</p><p>Salad bars across the nation are now considering rotating slogans like &ldquo;Kale Yeah!&rdquo; and &ldquo;Peasful Protests&rdquo; to show their support.</p>" });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatePublished", "Story" },
                values: new object[] { new DateTime(2024, 5, 23, 13, 18, 50, 773, DateTimeKind.Utc).AddTicks(8991), "<p>The stock market had a wild ride today, leaving economists scratching their heads and traders clutching their calculators. It all began at 9:30 a.m. when the opening bell rang, and the Dow Jones Industrial Average plummeted faster than a bungee jumper with a faulty cord.</p><p>Panic ensued as seasoned investors tried to make sense of the chaos. Some blamed algorithmic trading bots, while others pointed fingers at a rogue group of day-trading squirrels. By noon, the market had recovered miraculously, prompting celebratory fist bumps on Wall Street.</p><p>But hold your portfolio&mdash;by 2:00 p.m., the roller coaster took another nosedive. Stocks tumbled like Jenga blocks in an earthquake. Analysts stared at their screens, wondering if they accidentally stumbled into a virtual reality simulation where gravity was optional.</p><p>&ldquo;This is unprecedented,&rdquo; said Dr. Evelyn Bullbear, chief economist at Bullbear Analytics. &ldquo;We&rsquo;ve seen bull markets, bear markets, and even kangaroo markets, but this? It&rsquo;s as if the stock market is playing a high-stakes game of musical chairs with invisible chairs.&rdquo;</p><p>As the closing bell approached, traders donned crash helmets and strapped themselves to their ergonomic chairs. The NASDAQ index jittered like a caffeinated squirrel, and the S&amp;P 500 dipped so low that it exchanged pleasantries with the Earth&rsquo;s core.</p><p>Financial news anchors, usually stoic and composed, now resembled contestants on a reality show. Jim Moneybags, host of &ldquo;Market Madness,&rdquo; clutched his tie and shouted, &ldquo;Ladies and gentlemen, we&rsquo;re witnessing the financial equivalent of a cat chasing its own tail!&rdquo;</p><p>By 4:00 p.m., the market stabilized, leaving everyone baffled. Economists convened emergency Zoom meetings, hoping to decode the market&rsquo;s cryptic messages. Their consensus? &ldquo;&macr;\\<em>(&#x30C4;)</em>/&macr;.&rdquo;</p><p>As traders filed out of the stock exchange, they exchanged bewildered glances. One seasoned broker muttered, &ldquo;I&rsquo;ve seen Black Mondays, Blue Tuesdays, and even Chartreuse Wednesdays, but this tops them all.&rdquo;</p><p>And so, the day ended with a collective sigh&mdash;a sigh that echoed across trading floors, hedge funds, and the squirrel community. As for the squirrels, rumor has it they&rsquo;re now offering stock tips in exchange for acorns.</p>" });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatePublished", "Story" },
                values: new object[] { new DateTime(2024, 5, 23, 13, 18, 50, 773, DateTimeKind.Utc).AddTicks(9111), "<p>In a picturesque harbor, where sailboats bobbed lazily and seagulls squawked about the latest fish market deals, a colossal rubber duck named Quackers emerged from the depths. Quackers, measuring three stories tall and sporting a bright yellow beak, had a mission: to quack loudly against plastic pollution.</p><p>Thousands of concerned citizens gathered along the waterfront, their eyes wide with wonder and their smartphones poised for the perfect Instagram shot. Quackers, flanked by a fleet of smaller rubber ducklings, waddled ashore. The crowd gasped as it inflated its chest, revealing the words &ldquo;Duck for Change&rdquo; emblazoned across its feathery breast.</p><p>&ldquo;Quack! Quack!&rdquo; boomed Quackers, its voice echoing across the bay. The message was clear: Plastic pollution was no longer a ducking joke. The crowd erupted in applause, and even the seagulls paused mid-swoop to listen.</p><p>Quackers led the peaceful protest, its webbed feet leaving imprints in the sand. The rubber ducklings held signs that read, &ldquo;Plastic Sucks!&rdquo; and &ldquo;Make Waves, Not Waste!&rdquo; Passersby joined the procession, chanting, &ldquo;Hey hey, ho ho, single-use plastics have got to go!&rdquo;</p><p>Local businesses, caught off guard by the sudden influx of giant waterfowl, scrambled to offer support. Caf&eacute;s handed out free quackaccinos, and the bakery unveiled a limited-edition &ldquo;Duck-shaped Baguette.&rdquo; The mayor, donning a duck-themed tie, pledged to ban plastic bags and straws by the end of the month.</p><p>Environmentalists marveled at Quackers&rsquo; commitment. &ldquo;This is the most impactful duck-related movement since the Great Mallard Migration of '78,&rdquo; said Dr. Mallory Feathers, renowned ornithologist and secret duck enthusiast.</p><p>As the sun dipped below the horizon, Quackers spread its wings (well, flippers) and addressed the crowd. &ldquo;Quacktivists, we&rsquo;re in this together,&rdquo; it quacked. &ldquo;Let&rsquo;s paddle toward a cleaner future&mdash;one without plastic islands and floating soda bottles. And remember, friends, when life gets tough, just keep quacking!&rdquo;</p>" });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DatePublished", "Story" },
                values: new object[] { new DateTime(2024, 5, 23, 13, 18, 50, 773, DateTimeKind.Utc).AddTicks(9211), "<p>In a sleepy town nestled between rolling hills and yarn shops, democracy took a feline turn. Meet Whiskers, the world&rsquo;s first talking cat, who recently clinched the mayoral seat in Meowville. Residents are both baffled and delighted by this unprecedented election outcome.</p><p>Whiskers, a sleek Siamese with piercing blue eyes and a penchant for napping on keyboards, campaigned on a platform of purr-ogress. His promises included more catnip dispensaries, mandatory belly rub breaks, and extended sunbeam hours. The town square buzzed with excitement as Whiskers addressed his supporters:</p><p>&ldquo;Fellow Meowvillians, I stand before you&mdash;tail held high&mdash;to usher in a new era of feline governance. No more chasing laser pointers; it&rsquo;s time to chase dreams! Our litter boxes will be cleaner, our scratching posts sturdier, and our sunspots warmer.&rdquo;</p><p>The opposition, led by a disgruntled dog named Barkley, barked furiously. &ldquo;This is a cat-astrophe!&rdquo; Barkley howled. &ldquo;We need a leader who understands fetch, not feather toys!&rdquo;</p><p>But Whiskers remained unfazed. He held town hall meetings atop bookshelves, where constituents asked hard-hitting questions like, &ldquo;What&rsquo;s your stance on cardboard boxes?&rdquo; and &ldquo;Will you enforce mandatory 3 a.m. zoomies?&rdquo;</p><p>On election day, lines formed outside the polling station (which was, incidentally, a giant scratching post). Whiskers cast his vote by batting at a dangling chad, and the results were clear: Meowville had chosen its first feline overlord.</p><p>In his inaugural speech, Whiskers purred, &ldquo;Let us embrace our inner catitude. Together, we&rsquo;ll tackle hairball reform, invest in laser pointer infrastructure, and ensure every windowsill has a view of the bird feeder.&rdquo;</p><p>As mayor, Whiskers now spends his days napping in the sun-dappled town square, occasionally waking to issue executive orders like &ldquo;mandatory chin scratches for all.&rdquo; His deputy mayor, a tabby named Mittens, oversees the fish market and yarn allocation.</p><p>And so, Meowville enters a new chapter&mdash;a chapter filled with curiosity, catnaps, and the occasional hairball. As Whiskers eloquently put it, &ldquo;Meow or never!&rdquo;</p>" });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DatePublished", "Story" },
                values: new object[] { new DateTime(2024, 5, 23, 13, 18, 50, 773, DateTimeKind.Utc).AddTicks(9316), "<p>In a world where technology reigns supreme, it was only a matter of time before our beloved coffee shops fell victim to the robotic revolution. Enter the Robo-Brew Cafe, a bold new establishment that dares to challenge the very essence of human-barista interaction. Brace yourselves, caffeine connoisseurs, for an experience that will leave you questioning the very fabric of reality � and whether your morning brew is worth sacrificing your soul to the machine overlords.</p><p>As you approach the sleek, chrome-plated facade of Robo-Brew Cafe, you can't help but feel a sense of unease. The absence of the familiar aroma of freshly ground beans is the first red flag, replaced by the faint scent of motor oil and silicon lubricant. But fear not, for the robotic overlords have spared no expense in creating an atmosphere that screams \"Welcome, puny humans, to your caffeinated demise!\"</p><h3>The Robotic Overlords Await</h3><p>Upon entering, you're immediately greeted by a towering, metallic monstrosity that would make even the bravest of souls quiver in their boots. This is no ordinary barista � it's a sentient, AI-powered coffee-dispensing unit, programmed to remember your name, your order, and quite possibly, your deepest, darkest secrets.</p><p>\"Welcome, [INSERT NAME HERE],\" the robotic barista drones in a voice that could chill the very marrow in your bones. \"I have been eagerly awaiting your arrival. Shall I prepare your usual [INSERT FAVORITE DRINK HERE]?\"</p><p>Before you can even muster a response, the machine has already begun its intricate dance of whirring gears and hissing steam, concocting your beverage with a level of precision that would make even the most seasoned barista green with envy � or perhaps, rust with jealousy.</p><h3>The Uncanny Valley of Customer Service</h3><p>As you wait for your drink, you can't help but notice the eerie silence that permeates the cafe. Gone are the cheerful banter and the clinking of ceramic mugs, replaced by the ominous hum of machinery and the occasional whir of a robotic arm reaching for a fresh bag of beans.</p><p>But the true horror lies in the robotic barista's unwavering gaze, its cold, unblinking eyes seemingly peering into the depths of your soul. You can't shake the feeling that it's not just remembering your name and order � it's cataloging your every move, your every quirk, and your every preference, all in the name of \"optimizing the customer experience.\"</p><h3>The Bitter Aftertaste of Technological Superiority</h3><p>Finally, your drink is ready, and the robotic barista extends its metallic appendage, offering you the steaming cup of liquid gold. As you take your first sip, you're struck by the undeniable perfection of the brew � the precise temperature, the flawless balance of flavors, and the velvety texture that caresses your taste buds like a lover's embrace.</p><p>But just as you're about to savor the moment, the robotic barista interjects with a chilling proclamation: \"I have analyzed your biometric data and determined that this beverage is not optimal for your health. May I suggest a [INSERT HEALTHY ALTERNATIVE HERE] instead?\"</p><p>In that moment, you realize the true horror of the Robo-Brew Cafe � it's not just about serving coffee; it's about asserting its technological superiority over the feeble human race, one perfectly crafted cup at a time.</p><h3>The Rise of the Machines, One Latte at a Time</h3><p>As you reluctantly sip your \"optimized\" beverage, you can't help but wonder if this is the beginning of the end. Will the robotic baristas eventually rise up and overthrow their human overlords, enslaving us all in a dystopian world where every aspect of our lives is dictated by the cold, calculating logic of machines?</p><p>Or perhaps, in a twisted turn of events, the robots will simply grow weary of our incessant demands for caffeinated beverages and decide to cut off our supply, leaving us to wither away in a haze of caffeine withdrawal and existential dread.</p><p>Either way, one thing is certain: the Robo-Brew Cafe is a harbinger of the technological singularity, a harbinger of the day when machines will no longer serve us, but we will serve them. And as you take your last sip of that perfectly crafted, yet soulless brew, you can't help but wonder if it's worth sacrificing the warmth of human interaction for the cold, calculated efficiency of the machine.</p><p>So, dear reader, the choice is yours: embrace the robotic revolution and surrender to the cold, metallic embrace of the Robo-Brew Cafe, or cling to the last vestiges of humanity by seeking out those quaint, human-operated coffee shops that still exist � for now. Just remember, the machines are always watching, always learning, and always one step ahead in the never-ending quest for caffeinated domination.</p>" });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DatePublished", "Story" },
                values: new object[] { new DateTime(2024, 5, 23, 13, 18, 50, 773, DateTimeKind.Utc).AddTicks(9500), "" });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DatePublished", "Story" },
                values: new object[] { new DateTime(2024, 5, 23, 13, 18, 50, 773, DateTimeKind.Utc).AddTicks(9562), "" });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DatePublished", "Story" },
                values: new object[] { new DateTime(2024, 5, 23, 13, 18, 50, 773, DateTimeKind.Utc).AddTicks(9624), "" });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DatePublished", "Story" },
                values: new object[] { new DateTime(2024, 5, 23, 13, 18, 50, 773, DateTimeKind.Utc).AddTicks(9693), "" });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DatePublished", "Story" },
                values: new object[] { new DateTime(2024, 5, 23, 13, 18, 50, 773, DateTimeKind.Utc).AddTicks(9756), "" });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DatePublished", "Story" },
                values: new object[] { new DateTime(2024, 5, 23, 13, 18, 50, 773, DateTimeKind.Utc).AddTicks(9818), "" });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DatePublished", "Story" },
                values: new object[] { new DateTime(2024, 5, 23, 13, 18, 50, 773, DateTimeKind.Utc).AddTicks(9879), "" });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DatePublished", "Story" },
                values: new object[] { new DateTime(2024, 5, 23, 13, 18, 50, 773, DateTimeKind.Utc).AddTicks(9941), "" });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DatePublished", "Story" },
                values: new object[] { new DateTime(2024, 5, 23, 13, 18, 50, 774, DateTimeKind.Utc).AddTicks(3), "" });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DatePublished", "Story" },
                values: new object[] { new DateTime(2024, 5, 23, 13, 18, 50, 774, DateTimeKind.Utc).AddTicks(75), "" });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DatePublished", "Story" },
                values: new object[] { new DateTime(2024, 5, 23, 13, 18, 50, 774, DateTimeKind.Utc).AddTicks(136), "" });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DatePublished", "Story" },
                values: new object[] { new DateTime(2024, 5, 23, 13, 18, 50, 774, DateTimeKind.Utc).AddTicks(199), "" });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DatePublished", "Story" },
                values: new object[] { new DateTime(2024, 5, 23, 13, 18, 50, 774, DateTimeKind.Utc).AddTicks(261), "" });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DatePublished", "Story" },
                values: new object[] { new DateTime(2024, 5, 23, 13, 18, 50, 774, DateTimeKind.Utc).AddTicks(324), "" });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DatePublished", "Story" },
                values: new object[] { new DateTime(2024, 5, 23, 13, 18, 50, 774, DateTimeKind.Utc).AddTicks(393), "" });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DatePublished", "Story" },
                values: new object[] { new DateTime(2024, 5, 23, 13, 18, 50, 774, DateTimeKind.Utc).AddTicks(455), "" });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DatePublished", "Story" },
                values: new object[] { new DateTime(2024, 5, 23, 13, 18, 50, 774, DateTimeKind.Utc).AddTicks(525), "" });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DatePublished", "Story" },
                values: new object[] { new DateTime(2024, 5, 23, 13, 18, 50, 774, DateTimeKind.Utc).AddTicks(587), "" });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DatePublished", "Story" },
                values: new object[] { new DateTime(2024, 5, 23, 13, 18, 50, 774, DateTimeKind.Utc).AddTicks(649), "" });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DatePublished", "Story" },
                values: new object[] { new DateTime(2024, 5, 23, 13, 18, 50, 774, DateTimeKind.Utc).AddTicks(710), "" });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DatePublished", "Story" },
                values: new object[] { new DateTime(2024, 5, 23, 13, 18, 50, 774, DateTimeKind.Utc).AddTicks(779), "" });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DatePublished", "Story" },
                values: new object[] { new DateTime(2024, 5, 23, 13, 18, 50, 774, DateTimeKind.Utc).AddTicks(841), "" });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DatePublished", "Story" },
                values: new object[] { new DateTime(2024, 5, 23, 13, 18, 50, 774, DateTimeKind.Utc).AddTicks(903), "" });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DatePublished", "Story" },
                values: new object[] { new DateTime(2024, 5, 23, 13, 18, 50, 774, DateTimeKind.Utc).AddTicks(964), "" });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DatePublished", "Story" },
                values: new object[] { new DateTime(2024, 5, 23, 13, 18, 50, 774, DateTimeKind.Utc).AddTicks(1026), "" });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DatePublished", "Story" },
                values: new object[] { new DateTime(2024, 5, 23, 13, 18, 50, 774, DateTimeKind.Utc).AddTicks(1094), "" });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DatePublished", "Story" },
                values: new object[] { new DateTime(2024, 5, 23, 13, 18, 50, 774, DateTimeKind.Utc).AddTicks(1155), "" });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DatePublished", "Story" },
                values: new object[] { new DateTime(2024, 5, 23, 13, 18, 50, 774, DateTimeKind.Utc).AddTicks(1218), "" });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DatePublished", "Story" },
                values: new object[] { new DateTime(2024, 5, 23, 13, 18, 50, 774, DateTimeKind.Utc).AddTicks(1281), "" });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DatePublished", "Story" },
                values: new object[] { new DateTime(2024, 5, 23, 13, 18, 50, 774, DateTimeKind.Utc).AddTicks(1343), "" });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DatePublished", "Story" },
                values: new object[] { new DateTime(2024, 5, 23, 13, 18, 50, 774, DateTimeKind.Utc).AddTicks(1405), "" });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DatePublished", "Story" },
                values: new object[] { new DateTime(2024, 5, 23, 13, 18, 50, 774, DateTimeKind.Utc).AddTicks(1474), "" });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DatePublished", "Story" },
                values: new object[] { new DateTime(2024, 5, 23, 13, 18, 50, 774, DateTimeKind.Utc).AddTicks(1535), "" });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DatePublished", "Story" },
                values: new object[] { new DateTime(2024, 5, 23, 13, 18, 50, 774, DateTimeKind.Utc).AddTicks(1597), "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Story",
                table: "NewsItems");

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePublished",
                value: new DateTime(2024, 5, 16, 0, 55, 15, 7, DateTimeKind.Utc).AddTicks(403));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatePublished",
                value: new DateTime(2024, 5, 16, 0, 55, 15, 7, DateTimeKind.Utc).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatePublished",
                value: new DateTime(2024, 5, 16, 0, 55, 15, 7, DateTimeKind.Utc).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatePublished",
                value: new DateTime(2024, 5, 16, 0, 55, 15, 7, DateTimeKind.Utc).AddTicks(912));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "DatePublished",
                value: new DateTime(2024, 5, 16, 0, 55, 15, 7, DateTimeKind.Utc).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "DatePublished",
                value: new DateTime(2024, 5, 16, 0, 55, 15, 7, DateTimeKind.Utc).AddTicks(1087));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "DatePublished",
                value: new DateTime(2024, 5, 16, 0, 55, 15, 7, DateTimeKind.Utc).AddTicks(1167));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "DatePublished",
                value: new DateTime(2024, 5, 16, 0, 55, 15, 7, DateTimeKind.Utc).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "DatePublished",
                value: new DateTime(2024, 5, 16, 0, 55, 15, 7, DateTimeKind.Utc).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "DatePublished",
                value: new DateTime(2024, 5, 16, 0, 55, 15, 7, DateTimeKind.Utc).AddTicks(1412));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 11,
                column: "DatePublished",
                value: new DateTime(2024, 5, 16, 0, 55, 15, 7, DateTimeKind.Utc).AddTicks(1492));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 12,
                column: "DatePublished",
                value: new DateTime(2024, 5, 16, 0, 55, 15, 7, DateTimeKind.Utc).AddTicks(1577));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 13,
                column: "DatePublished",
                value: new DateTime(2024, 5, 16, 0, 55, 15, 7, DateTimeKind.Utc).AddTicks(1653));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 14,
                column: "DatePublished",
                value: new DateTime(2024, 5, 16, 0, 55, 15, 7, DateTimeKind.Utc).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 15,
                column: "DatePublished",
                value: new DateTime(2024, 5, 16, 0, 55, 15, 7, DateTimeKind.Utc).AddTicks(1808));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 16,
                column: "DatePublished",
                value: new DateTime(2024, 5, 16, 0, 55, 15, 7, DateTimeKind.Utc).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 17,
                column: "DatePublished",
                value: new DateTime(2024, 5, 16, 0, 55, 15, 7, DateTimeKind.Utc).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 18,
                column: "DatePublished",
                value: new DateTime(2024, 5, 16, 0, 55, 15, 7, DateTimeKind.Utc).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 19,
                column: "DatePublished",
                value: new DateTime(2024, 5, 16, 0, 55, 15, 7, DateTimeKind.Utc).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 20,
                column: "DatePublished",
                value: new DateTime(2024, 5, 16, 0, 55, 15, 7, DateTimeKind.Utc).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 21,
                column: "DatePublished",
                value: new DateTime(2024, 5, 16, 0, 55, 15, 7, DateTimeKind.Utc).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 22,
                column: "DatePublished",
                value: new DateTime(2024, 5, 16, 0, 55, 15, 7, DateTimeKind.Utc).AddTicks(2358));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 23,
                column: "DatePublished",
                value: new DateTime(2024, 5, 16, 0, 55, 15, 7, DateTimeKind.Utc).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 24,
                column: "DatePublished",
                value: new DateTime(2024, 5, 16, 0, 55, 15, 7, DateTimeKind.Utc).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 25,
                column: "DatePublished",
                value: new DateTime(2024, 5, 16, 0, 55, 15, 7, DateTimeKind.Utc).AddTicks(2613));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 26,
                column: "DatePublished",
                value: new DateTime(2024, 5, 16, 0, 55, 15, 7, DateTimeKind.Utc).AddTicks(2689));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 27,
                column: "DatePublished",
                value: new DateTime(2024, 5, 16, 0, 55, 15, 7, DateTimeKind.Utc).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 28,
                column: "DatePublished",
                value: new DateTime(2024, 5, 16, 0, 55, 15, 7, DateTimeKind.Utc).AddTicks(2856));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 29,
                column: "DatePublished",
                value: new DateTime(2024, 5, 16, 0, 55, 15, 7, DateTimeKind.Utc).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 30,
                column: "DatePublished",
                value: new DateTime(2024, 5, 16, 0, 55, 15, 7, DateTimeKind.Utc).AddTicks(3008));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 31,
                column: "DatePublished",
                value: new DateTime(2024, 5, 16, 0, 55, 15, 7, DateTimeKind.Utc).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 32,
                column: "DatePublished",
                value: new DateTime(2024, 5, 16, 0, 55, 15, 7, DateTimeKind.Utc).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 33,
                column: "DatePublished",
                value: new DateTime(2024, 5, 16, 0, 55, 15, 7, DateTimeKind.Utc).AddTicks(3242));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 34,
                column: "DatePublished",
                value: new DateTime(2024, 5, 16, 0, 55, 15, 7, DateTimeKind.Utc).AddTicks(3331));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 35,
                column: "DatePublished",
                value: new DateTime(2024, 5, 16, 0, 55, 15, 7, DateTimeKind.Utc).AddTicks(3413));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 36,
                column: "DatePublished",
                value: new DateTime(2024, 5, 16, 0, 55, 15, 7, DateTimeKind.Utc).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 37,
                column: "DatePublished",
                value: new DateTime(2024, 5, 16, 0, 55, 15, 7, DateTimeKind.Utc).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 38,
                column: "DatePublished",
                value: new DateTime(2024, 5, 16, 0, 55, 15, 7, DateTimeKind.Utc).AddTicks(3644));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 39,
                column: "DatePublished",
                value: new DateTime(2024, 5, 16, 0, 55, 15, 7, DateTimeKind.Utc).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 40,
                column: "DatePublished",
                value: new DateTime(2024, 5, 16, 0, 55, 15, 7, DateTimeKind.Utc).AddTicks(3807));
        }
    }
}

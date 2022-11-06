using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace server.Models
{
    public class DB
    {
        public static List<User> UsersList { get; set; } = new List<User>()
        {
            new User("1","ora","matitiao","hfsji;l@fhb","1234"),
            new User("2","riki","simtat azar","hfsji;l@fhb","1111"),
            new User("3","avigail","levin","hfsji;l@fhb","2222"),
            new User("4","someOne","someWhere","gmail@gmail.com","3333")
        };
        public static List<Recipe> RecipeList { get; set; } = new List<Recipe>()
        {
                        new Recipe("1","Perfect home-made pizza","7777",30,3,new DateTime(),new List<string>(){"3 Cups or 420 grams of yeast flour","1.13 Glass or 240 ml of warm water", "3 tablespoons olive oil", "Tablespoon white sugar", "Flat teaspoon fine salt" ,"Olive oil spray", "3 tablespoons olive oil", "6 medium tomatoes", "3 tablespoons soy sauce", "3 cloves of garlic", "0.75 teaspoon dry oregano", "Teaspoon ground black pepperTopping","300 grams of mozzarella cheese","Grated + toppings of your choice (tomato slices, cucumber, pitted olives, purple onion slices, etc.)"},new List<string>(){ "Prepare the dough and puff: In a large bowl, put the dough ingredients in your hands for about 5 minutes (or about 10 minutes in a mixer with a kneading hook), until you get a soft, flexible and slightly sticky dough.", "Transfer the dough to a greased bowl. Grease the dough dome with a little oil spray so that it does not dry out. Cover with cling film and puff for about an hour, until the dough doubles in volume.", "Meanwhile, prepare the sauce for the pizza: coarsely chop the tomatoes and garlic. Heat a frying pan over a medium flame, add the sauce ingredients and bring to a boil. Lower the flame and cook for about 10 minutes, stirring occasionally until a sauce is obtained. Taste and adjust seasoning. Cool well.","Preheat oven to 200 degrees.@", "Assemble the pizza and bake: Divide the dough in half and roll each piece on baking paper into a circle 25 cm in diameter and 3 mm thick. Transfer with the paper to the molds. Spread tomato sauce evenly and sprinkle with mozzarella cheese and toppings.", "Bake in the hot oven for 20-15 minutes, until the edges of the pizza are golden and the cheese is melted.", "Remove from the oven, smell the product: a perfect homemade pizza and serve with love." },"1","a.jpg"),
            new Recipe("2","Pepperella pasta muffins and cheeses","5555",50,4,new DateTime(),new List<string>(){ "1/2 packet pappardelle pasta", "1 pack spinach leaves", "5 cloves of garlic", "2 eggs L", "500 grams of 9% white cheese", "200 grams of Bulgarian cheese", "1 cup white flou", "1 1/2 teaspoons baking powder", "1 pinch ground black pepper", },new List<string>(){ "Preheat oven to 180 degrees.", "Cook the pasta according to the manufacturer's instructions and strain.", "Chop the spinach, tomato and chives and place in a large bowl, crush the garlic and add to the bowl add the flour, eggs and cheeses and mix well add the rest of the ingredients and mix well.", "Add the filtered pasta and mix.@", "Transfer the mixture to snow sushi - paper baking pans for muffins and bake for about 30-35 minutes until the muffins are puffed and browned."},"2","n.jpg"),
            new Recipe("3","Creamy pasta and mushrooms","5555",45,4,new DateTime(),new List<string>{ "1 packet of fettuccine pasta", "2 liters of boiling water", "50 grams of butter", "1 medium onion", "1 basket champignon mushrooms", "1 container of whipping cream", "1/2 teaspoon fine salt", "1/4 teaspoon nutmeg", "1/4 teaspoon ground black pepp"},new List<string>{ "Prepare the sauce: Heat the butter in a saucepan (be careful not to burn it) and sauté the onion in the butter while stirring.", "Add the mushrooms and cook together for another 10 minutes, stirring occasionally.", "Add sweet cream, mix and bring to the boil.", "Lower the flame, add salt, nutmeg and pepper. Stir and cook for another 5 minutes (taste and adjust the seasoning)", "Prepare the pasta: Put the pasta in the pot of boiling water and cook according to the manufacturer's instructions", "Drain the pasta from the water. Add to the sauce pot and stir.", "Serve the dish: Transfer to serving plates and sprinkle a little Parmesan cheese on top.", "","","",},"1","o.jpg"),
            new Recipe("4","Personalized cakes with crispy icing","6666",60,4,new DateTime(),new List<string>{ "1 container sweet cream", "2 eggs L", "2/3 cup white sugar", "1 bag of vanilla sugar", "1 1/4 cups puffed flo", "2 tablespoons cocoa powder", "6 tablespoons 3% milk", "200 grams of Zafiro milk"},new List<string>{ "Prepare the cakes: Preheat the oven to 180 degrees.", "Whip the sweet cream into a stable whipped cream and add the eggs, sugar, vanilla sugar and puffed flour", "Prepare the chocolate batter: Mix the cocoa with the milk and add to a third of the whipped mixture.", "Flatten the mixtures together in a well-greased magnum pan. Mix lightly for a marble sample. It can also be prepared in a flat oven pan for a flat cake from which we will whip popsicles with a round cutter that is slightly shaped into an oval shape.", "Put in the oven and bake for 20 minutes.", "Cool completely and refrigerate briefly in the freezer or refrigerator for stabilization (just for convenience of work).", "Prepare the popsicles: If you are baking in a magnum pan, release from the pan and place on a tray lined with baking paper (the size that goes into the freezer). If you bake in an oven dish, cut out ovals (using a cookie cutter about 6 cm in diameter, which is curved by pressing on the work surface).", "Dip one end of a popsicle stick into the dissolved zephyr (as a 'glue') and stick in the cakes.", "Transfer to the freezer to harden so that the cake does not fall apart during icing.", "Melt the zephyr in the microwave and transfer to a narrow, tall vessel to facilitate dipping.", "Dip the frozen cakes in the icing (hold the stick) and place on baking paper to harden. Thaw and serve."},"2","ice.jpg"),
            new Recipe("5","Special pancakes","6666",75,5,new DateTime(),new List<string>{ "2 eggs","1.5 cups of flour", "Teaspoon baking powder", "bakinng-powder", "1.5 tablespoons honey / sesame / brown sugar", "Cup of milk / vegetable milk (soy, almonds or oats)"},new List<string>{ "-Mix all the ingredients well in a bowl with a whisk until smooth overnight.", "Grease a pan with butter or oil (you can use a wide regular pan with a non-stick coating or a pancake pan) and when the pan is hot, pour the batter into the pan with a ladle (of soup).", "-After about a minute, when small bubbles appear on top of the pancakes, turn aside and leave for another 1/2 minute.", "* Recommended with chocolate / maple syrup.@"},"2","b.jpg"),
            new Recipe("6","3-levels cake","1111",60,4,new DateTime(),new List<string>{ "1 container sweet cream", "2 eggs L", "2/3 cup white sugar", "1 bag of vanilla sugar", "1 1/4 cups puffed flour", "2 tablespoons cocoa powder", "6 tablespoons 3% milk", "200 grams of Zafiro milk"},new List<string>{ "Prepare the cakes: Preheat the oven to 180 degrees.", "Whip the sweet cream into a stable whipped cream and add the eggs, sugar, vanilla sugar and puffed flour.", "Prepare the chocolate batter: Mix the cocoa with the milk and add to a third of the whipped mixture.", "Flatten the mixtures together in a well-greased magnum pan. Mix lightly for a marble sample. It can also be prepared in a flat oven pan for a flat cake from which we will whip popsicles with a round cutter that is slightly shaped into an oval shape.", "Put in the oven and bake for 20 minutes", "Cool completely and refrigerate briefly in the freezer or refrigerator for stabilization (just for convenience of work)", "Prepare the popsicles: If you are baking in a magnum pan, release from the pan and place on a tray lined with baking paper (the size that goes into the freezer). If you bake in an oven dish, cut out ovals (using a cookie cutter about 6 cm in diameter, which is curved by pressing on the work surface).", "Dip one end of a popsicle stick into the dissolved zephyr (as a 'glue') and stick in the cakes.", "Transfer to the freezer to harden so that the cake does not fall apart during icing.", "Melt the zephyr in the microwave and transfer to a narrow, tall vessel to facilitate dipping.", "Dip the frozen cakes in the icing (hold the stick) and place on baking paper to harden. Thaw and serve"},"2","l2.jpg"),
            new Recipe("7","high chocolate cake","1111",60,4,new DateTime(),new List<string>{ "1 container sweet cream", "2 eggs L", "2/3 cup white sugar", "1 bag of vanilla sugar", "1 1/4 cups puffed flour", "2 tablespoons cocoa powder", "6 tablespoons 3% milk", "200 grams of Zafiro milk"},new List<string>{ "Prepare the cakes: Preheat the oven to 180 degrees.", "Whip the sweet cream into a stable whipped cream and add the eggs, sugar, vanilla sugar and puffed flour.", "Prepare the chocolate batter: Mix the cocoa with the milk and add to a third of the whipped mixture.", "Flatten the mixtures together in a well-greased magnum pan. Mix lightly for a marble sample. It can also be prepared in a flat oven pan for a flat cake from which we will whip popsicles with a round cutter that is slightly shaped into an oval shape.", "Put in the oven and bake for 20 minutes.", "Cool completely and refrigerate briefly in the freezer or refrigerator for stabilization (just for convenience of work).", "Prepare the popsicles: If you are baking in a magnum pan, release from the pan and place on a tray lined with baking paper (the size that goes into the freezer). If you bake in an oven dish, cut out ovals (using a cookie cutter about 6 cm in diameter, which is curved by pressing on the work surface).", "Dip one end of a popsicle stick into the dissolved zephyr (as a 'glue') and stick in the cakes.", "Transfer to the freezer to harden so that the cake does not fall apart during icing.", "Melt the zephyr in the microwave and transfer to a narrow, tall vessel to facilitate dipping.", "Dip the frozen cakes in the icing (hold the stick) and place on baking paper to harden. Thaw and serve"},"l","ice.jpg"),
            new Recipe("8","special cake for birthday","1111",60,4,new DateTime(),new List<string>{ "1 container sweet cream", "2 eggs L", "2/3 cup white sugar", "1 bag of vanilla sugar", "1 1/4 cups puffed flour", "2 tablespoons cocoa powder", "6 tablespoons 3% milk", "200 grams of Zafiro milk"},new List<string>{ "Prepare the cakes: Preheat the oven to 180 degrees.", "Whip the sweet cream into a stable whipped cream and add the eggs, sugar, vanilla sugar and puffed flour.", "Prepare the chocolate batter: Mix the cocoa with the milk and add to a third of the whipped mixture.", "Flatten the mixtures together in a well-greased magnum pan. Mix lightly for a marble sample. It can also be prepared in a flat oven pan for a flat cake from which we will whip popsicles with a round cutter that is slightly shaped into an oval shape.", "Put in the oven and bake for 20 minutes.", "Cool completely and refrigerate briefly in the freezer or refrigerator for stabilization (just for convenience of work).", "Prepare the popsicles: If you are baking in a magnum pan, release from the pan and place on a tray lined with baking paper (the size that goes into the freezer). If you bake in an oven dish, cut out ovals (using a cookie cutter about 6 cm in diameter, which is curved by pressing on the work surface).", "Dip one end of a popsicle stick into the dissolved zephyr (as a 'glue') and stick in the cakes.", "Transfer to the freezer to harden so that the cake does not fall apart during icing.", "Melt the zephyr in the microwave and transfer to a narrow, tall vessel to facilitate dipping.", "Dip the frozen cakes in the icing (hold the stick) and place on baking paper to harden. Thaw and rve."},"2","k.jpg"),
            new Recipe("9","macaroons","2222",120,5,new DateTime(),new List<string>{ "1 container sweet cream", "2 eggs L", "2/3 cup white sugar", "1 bag of vanilla sugar", "1 1/4 cups puffed flour", "2 tablespoons cocoa powde", "6 tablespoons 3% milk", "200 grams of Zafiro milk"},new List<string>{ "Prepare the cakes: Preheat the oven to 180 degrees.", "Whip the sweet cream into a stable whipped cream and add the eggs, sugar, vanilla sugar and puffed flour.", "Prepare the chocolate batter: Mix the cocoa with the milk and add to a third of the whipped mixture.", "Flatten the mixtures together in a well-greased magnum pan. Mix lightly for a marble sample. It can also be prepared in a flat oven pan for a flat cake from which we will whip popsicles with a round cutter that is slightly shaped into an oval shape.", "Put in the oven and bake for 20 minutes.", "Cool completely and refrigerate briefly in the freezer or refrigerator for stabilization (just for convenience of work).", "Prepare the popsicles: If you are baking in a magnum pan, release from the pan and place on a tray lined with baking paper (the size that goes into the freezer). If you bake in an oven dish, cut out ovals (using a cookie cutter about 6 cm in diameter, which is curved by pressing on the work surface).", "Dip one end of a popsicle stick into the dissolved zephyr (as a 'glue') and stick in the cakes.", "Transfer to the freezer to harden so that the cake does not fall apart during icing.", "Melt the zephyr in the microwave and transfer to a narrow, tall vessel to facilitate dipping.", "Dip the frozen cakes in the icing (hold the stick) and place on baking paper to harden. Thaw and serve."},"1","c.jpg"),
            new Recipe("10","romantic salad","3333",15,1,new DateTime(),new List<string>{ "1 container sweet cream", "2 eggs L", "2/3 cup white sugar", "1 bag of vanilla sugar", "1 1/4 cups puffed flour", "2 tablespoons cocoa powde", "6 tablespoons 3% milk", "200 grams of Zafiro milk"},new List<string>{ "Prepare the cakes: Preheat the oven to 180 degrees.", "Whip the sweet cream into a stable whipped cream and add the eggs, sugar, vanilla sugar and puffed flour.", "Prepare the chocolate batter: Mix the cocoa with the milk and add to a third of the whipped mixture.", "Flatten the mixtures together in a well-greased magnum pan. Mix lightly for a marble sample. It can also be prepared in a flat oven pan for a flat cake from which we will whip popsicles with a round cutter that is slightly shaped into an oval shape.", "Put in the oven and bake for 20 minutes.", "Cool completely and refrigerate briefly in the freezer or refrigerator for stabilization (just for convenience of work).", "Prepare the popsicles: If you are baking in a magnum pan, release from the pan and place on a tray lined with baking paper (the size that goes into the freezer). If you bake in an oven dish, cut out ovals (using a cookie cutter about 6 cm in diameter, which is curved by pressing on the work surface).", "Dip one end of a popsicle stick into the dissolved zephyr (as a 'glue') and stick in the cakes.", "Transfer to the freezer to harden so that the cake does not fall apart during icing", "Melt the zephyr in the microwave and transfer to a narrow, tall vessel to facilitate dipping.", "Dip the frozen cakes in the icing (hold the stick) and place on baking paper to harden. Thaw and serve."},"2","i.jpg"),
            new Recipe("11","Cheese borax","7777",50,3,new DateTime(),new List<string>{ "1 container sweet cream", "2 eggs L", "2/3 cup white sugar", "1 bag of vanilla sugar", "1 1/4 cups puffed flour", "2 tablespoons cocoa powder", "6 tablespoons 3% milk", "200 grams of Zafiro milk"},new List<string>{ "Prepare the cakes: Preheat the oven to 180 degrees.", "Whip the sweet cream into a stable whipped cream and add the eggs, sugar, vanilla sugar and puffed flour.", "Prepare the chocolate batter: Mix the cocoa with the milk and add to a third of the whipped mixture.", "Flatten the mixtures together in a well-greased magnum pan. Mix lightly for a marble sample. It can also be prepared in a flat oven pan for a flat cake from which we will whip popsicles with a round cutter that is slightly shaped into an oval shape.", "Put in the oven and bake for 20 minutes.", "Cool completely and refrigerate briefly in the freezer or refrigerator for stabilization (just for convenience of work).", "Prepare the popsicles: If you are baking in a magnum pan, release from the pan and place on a tray lined with baking paper (the size that goes into the freezer). If you bake in an oven dish, cut out ovals (using a cookie cutter about 6 cm in diameter, which is curved by pressing on the work surface).", "Dip one end of a popsicle stick into the dissolved zephyr (as a 'glue') and stick in the cakes.", "Transfer to the freezer to harden so that the cake does not fall apart during icing.", "Melt the zephyr in the microwave and transfer to a narrow, tall vessel to facilitate dipping", "Dip the frozen cakes in the icing (hold the stick) and place on baking paper to harden. Thaw and serve."},"1","g.jpg"),
            new Recipe("12","sweet chalah","7777",25,2,new DateTime(),new List<string>{ "1 container sweet cream", "2 eggs L", "2/3 cup white sugar", "1 bag of vanilla sugar", "1 1/4 cups puffed flour", "2 tablespoons cocoa powder", "6 tablespoons 3% milk", "200 grams of Zafiro milk"},new List<string>{ "Prepare the cakes: Preheat the oven to 180 degrees.", "Whip the sweet cream into a stable whipped cream and add the eggs, sugar, vanilla sugar and puffed flour.", "Prepare the chocolate batter: Mix the cocoa with the milk and add to a third of the whipped mixture.", "Flatten the mixtures together in a well-greased magnum pan. Mix lightly for a marble sample. It can also be prepared in a flat oven pan for a flat cake from which we will whip popsicles with a round cutter that is slightly shaped into an oval shape.", "Put in the oven and bake for 20 minutes.", "Cool completely and refrigerate briefly in the freezer or refrigerator for stabilization (just for convenience of work).", "Prepare the popsicles: If you are baking in a magnum pan, release from the pan and place on a tray lined with baking paper (the size that goes into the freezer). If you bake in an oven dish, cut out ovals (using a cookie cutter about 6 cm in diameter, which is curved by pressing on the work surface).", "Dip one end of a popsicle stick into the dissolved zephyr (as a 'glue') and stick in the cakes.", "Transfer to the freezer to harden so that the cake does not fall apart during icing.", "Melt the zephyr in the microwave and transfer to a narrow, tall vessel to facilitate dippig.", "Dip the frozen cakes in the icing (hold the stick) and place on baking paper to harden. Thaw and serve."},"1","j.jpg"),
            new Recipe("13","fruit ice","6666",70,5,new DateTime(),new List<string>{ "1 container sweet cream", "2 eggs L", "2/3 cup white sugar", "1 bag of vanilla sugar", "1 1/4 cups puffed flour", "2 tablespoons cocoa powder", "6 tablespoons 3% milk", "200 grams of Zafiro milk"},new List<string>{ "Prepare the cakes: Preheat the oven to 180 degrees.", "Whip the sweet cream into a stable whipped cream and add the eggs, sugar, vanilla sugar and puffed flour.", "Prepare the chocolate batter: Mix the cocoa with the milk and add to a third of the whipped mixture.", "Flatten the mixtures together in a well-greased magnum pan. Mix lightly for a marble sample. It can also be prepared in a flat oven pan for a flat cake from which we will whip popsicles with a round cutter that is slightly shaped into an oval shape.", "Put in the oven and bake for 20 minutes.", "Cool completely and refrigerate briefly in the freezer or refrigerator for stabilization (just for convenience of work).", "Prepare the popsicles: If you are baking in a magnum pan, release from the pan and place on a tray lined with baking paper (the size that goes into the freezer). If you bake in an oven dish, cut out ovals (using a cookie cutter about 6 cm in diameter, which is curved by pressing on the work surface).", "Dip one end of a popsicle stick into the dissolved zephyr (as a 'glue') and stick in the cakes.", "Transfer to the freezer to harden so that the cake does not fall apart during icing.", "Melt the zephyr in the microwave and transfer to a narrow, tall vessel to facilitate dipping.", "Dip the frozen cakes in the icing (hold the stick) and place on baking paper to harden. Thaw and serve."},"1","f.jpg"),
            new Recipe("14","pekan conus","2222",90,5,new DateTime(),new List<string>{ "1 container sweet cream", "2 eggs L", "2/3 cup white sugar", "1 bag of vanilla sugar", "1 1/4 cups puffed flour", "2 tablespoons cocoa powder", "6 tablespoons 3% milk", "200 grams of Zafiro milk"},new List<string>{ "Prepare the cakes: Preheat the oven to 180 degrees.", "Whip the sweet cream into a stable whipped cream and add the eggs, sugar, vanilla sugar and puffed flour.", "Prepare the chocolate batter: Mix the cocoa with the milk and add to a third of the whipped mixture.", "Flatten the mixtures together in a well-greased magnum pan. Mix lightly for a marble sample. It can also be prepared in a flat oven pan for a flat cake from which we will whip popsicles with a round cutter that is slightly shaped into an oval shape.", "Put in the oven and bake for 20 minutes.", "Cool completely and refrigerate briefly in the freezer or refrigerator for stabilization (just for convenience of work).", "Prepare the popsicles: If you are baking in a magnum pan, release from the pan and place on a tray lined with baking paper (the size that goes into the freezer). If you bake in an oven dish, cut out ovals (using a cookie cutter about 6 cm in diameter, which is curved by pressing on the work surface).", "Dip one end of a popsicle stick into the dissolved zephyr (as a 'glue') and stick in the cakes.", "Transfer to the freezer to harden so that the cake does not fall apart during icing.", "Melt the zephyr in the microwave and transfer to a narrow, tall vessel to facilitate dipping.", "Dip the frozen cakes in the icing (hold the stick) and place on baking paper to harden. Thaw and serve."},"1","d.jpg"),
            new Recipe("15","sweet cake","1111",60,4,new DateTime(),new List<string>{ "1 container sweet cream", "2 eggs L", "2/3 cup white sugar", "1 bag of vanilla sugar", "1 1/4 cups puffed flour", "2 tablespoons cocoa powder", "6 tablespoons 3% milk", "200 grams of Zafiro milk"},new List<string>{ "Prepare the cakes: Preheat the oven to 180 degrees.", "Whip the sweet cream into a stable whipped cream and add the eggs, sugar, vanilla sugar and puffed flour.", "Prepare the chocolate batter: Mix the cocoa with the milk and add to a third of the whipped mixture.", "Flatten the mixtures together in a well-greased magnum pan. Mix lightly for a marble sample. It can also be prepared in a flat oven pan for a flat cake from which we will whip popsicles with a round cutter that is slightly shaped into an oval shape.", "Put in the oven and bake for 20 minutes.", "Cool completely and refrigerate briefly in the freezer or refrigerator for stabilization (just for convenience of work).", "Prepare the popsicles: If you are baking in a magnum pan, release from the pan and place on a tray lined with baking paper (the size that goes into the freezer). If you bake in an oven dish, cut out ovals (using a cookie cutter about 6 cm in diameter, which is curved by pressing on the work surface).", "Dip one end of a popsicle stick into the dissolved zephyr (as a 'glue') and stick in the cakes.", "Transfer to the freezer to harden so that the cake does not fall apart during icing.", "Melt the zephyr in the microwave and transfer to a narrow, tall vessel to facilitate dipping.", "Dip the frozen cakes in the icing (hold the stick) and place on baking paper to harden. Thaw and serve."},"2","1.JPG"),
            new Recipe("16","happy dessert","2222",60,4,new DateTime(),new List<string>{ "1 container sweet cream", "2 eggs L", "2/3 cup white sugar", "1 bag of vanilla sugar", "1 1/4 cups puffed flour", "2 tablespoons cocoa powder", "6 tablespoons 3% milk", "200 grams of Zafiro milk"},new List<string>{ "Prepare the cakes: Preheat the oven to 180 degrees.", "Whip the sweet cream into a stable whipped cream and add the eggs, sugar, vanilla sugar and puffed flour.", "Prepare the chocolate batter: Mix the cocoa with the milk and add to a third of the whipped mixtur", "Flatten the mixtures together in a well-greased magnum pan. Mix lightly for a marble sample. It can also be prepared in a flat oven pan for a flat cake from which we will whip popsicles with a round cutter that is slightly shaped into an oval shape.", "Put in the oven and bake for 20 minutes.", "Cool completely and refrigerate briefly in the freezer or refrigerator for stabilization (just for convenience of work).", "Prepare the popsicles: If you are baking in a magnum pan, release from the pan and place on a tray lined with baking paper (the size that goes into the freezer). If you bake in an oven dish, cut out ovals (using a cookie cutter about 6 cm in diameter, which is curved by pressing on the work surface).", "Dip one end of a popsicle stick into the dissolved zephyr (as a 'glue') and stick in the cakes.", "Transfer to the freezer to harden so that the cake does not fall apart during icing.", "Melt the zephyr in the microwave and transfer to a narrow, tall vessel to facilitate dipping.", "Dip the frozen cakes in the icing (hold the stick) and place on baking paper to harden. Thaw and serve."},"1","l.jpg"),
            new Recipe("17","diary-chocolate braunis","1111",60,4,new DateTime(),new List<string>{ "1 container sweet cream", "2 eggs L", "2/3 cup white sugar", "1 bag of vanilla sugar", "1 1/4 cups puffed flour", "2 tablespoons cocoa powder", "6 tablespoons 3% milk", "200 grams of Zafiro milk"},new List<string>{ "Prepare the cakes: Preheat the oven to 180 degrees.", "Whip the sweet cream into a stable whipped cream and add the eggs, sugar, vanilla sugar and puffed flour.", "Prepare the chocolate batter: Mix the cocoa with the milk and add to a third of the whipped mixture.", "Flatten the mixtures together in a well-greased magnum pan. Mix lightly for a marble sample. It can also be prepared in a flat oven pan for a flat cake from which we will whip popsicles with a round cutter that is slightly shaped into an oval shape.", "Put in the oven and bake for 20 minutes.", "Cool completely and refrigerate briefly in the freezer or refrigerator for stabilization (just for convenience of work).", "Prepare the popsicles: If you are baking in a magnum pan, release from the pan and place on a tray lined with baking paper (the size that goes into the freezer). If you bake in an oven dish, cut out ovals (using a cookie cutter about 6 cm in diameter, which is curved by pressing on the work surface).", "Dip one end of a popsicle stick into the dissolved zephyr (as a 'glue') and stick in the cakes.", "Transfer to the freezer to harden so that the cake does not fall apart during icing", "Melt the zephyr in the microwave and transfer to a narrow, tall vessel to facilitate dipping.", "Dip the frozen cakes in the icing (hold the stick) and place on baking paper to harden. Thaw and serve."},"1","e.jpg"),

            new Recipe("18","Ginger & white chocolate cake","1111",65,5,new DateTime(),
                new List<string>(){ "220g unsalted butter ",
                    "220g unsalted butter",
                    "365g self-raising flour",
                    "200g muscovado sugar",
                    "50g black treacle",
                    "150g golden syrup",
                    "2 large eggs",
                    "300ml milk",
                    "½ tsp cinnamon",
                },
                new List<string>(){
                    "Heat the oven to 180C/160C fan/gas 4. Melt 1 tbsp butter in a small pan, then stir in ½ tbsp flour to create a wet paste. Brush it over the inside of a 9-inch bundt tin. Put the remaining butter, sugar, treacle and golden syrup in a pan set over a medium heat and stir until everything has melted together. Leave to cool a little.",
                    "Pour the mixture into a large bowl and whisk in the eggs and milk. Fold in the stem ginger, remaining flour, salt, ground ginger, cinnamon and bicarb. Tip into the prepared tin and bake for 40-45 mins, or until firm to the touch. Leave to cool for 10 mins in the tin, then turn out onto a wire rack to cool completely.",
                    "To make the icing, whisk the milk, ginger syrup and icing sugar together. Melt the chocolate in a heatproof bowl in the microwave in 1-min bursts. Leave to cool a little, then whisk into the milk mixture. Spoon the icing over the cake, then decorate with the crystallised ginger pieces."
                },"1","ginger-and-white-choc-cake-2903ae9.webp"),


            new Recipe(
                "19",
                "bean soup",
                "4444",
                10,
                1,
                new DateTime(),
                new List<string>(){
                "4 tsp olive oil",
                "500g leeks",
                "4 thyme sprigs",
                "2 x 400g cans butter beans",
                "500ml vegetable bouillon stock",
                "2 tsp wholegrain mustard",
                "½ small pack flat-leaf parsley",
                "3 rashers streaky bacon",
                },
                new List<string>(){
                "Heat 1 tbsp oil in a large saucepan over a low heat. Add the leeks, thyme and seasoning. Cover and cook for 15 mins until softened, adding a splash of water if the leeks start to stick. Add the butter beans with the water from the cans, the stock and mustard. Bring to the boil and simmer for 3-4 mins until hot. Blend the soup in a food processor or with a stick blender, stir through the parsley and check the seasoning.",
                "Put the bacon in a large, non-stick frying pan over a medium heat. Cook for 3-4 mins until crispy, then set side to cool. Add the remaining 1 tsp oil to the pan, and tip in the kale and hazelnuts. Cook for 2 mins, stirring until the kale is wilted and crisping at the edges and the hazelnuts are toasted. Cut the bacon into small pieces, then stir into the kale mixture.",
                "Reheat the soup, adding a splash of water if it is too thick. Serve in bowls sprinkled with the bacon & kale mixture.",
                },
                "2",
                "leek-butter-bean-soup-b4d5048.webp"),


                new Recipe(
                "20",
                "Choux pastry recipes",
                "6666",
                130,
                5,
                new DateTime(),
                new List<string>(){
                "170g lightly salted butter",
                "200g plain flour",
                "5 medium eggs",
                "300ml milk",
                "150ml double cream",
                "3 egg yolks",
                "50g white caster sugar",
                },
                new List<string>(){
                "First, make the choux pastry. Put the butter in a saucepan with 450ml water. Sieve the flour into a large bowl and set aside. Bring the butter and water to a fast boil, simmer until the butter has melted, then tip in the flour and beat like mad with a wooden spoon until the mixture pulls away from the sides of the pan and is lump-free. Tip into the bowl and spread the thick paste up the sides a little to help it cool quickly, then leave for 10 mins.",
                "Heat oven to 200C/180C fan/ gas 6 and cut two pieces of baking parchment to fit two baking sheets. Using a ruler and pen, mark 10 lines about 12cm long over each piece, leaving plenty of space between the lines, then flip the parchment over. Fit a piping bag with a large round piping nozzle, about 1.5cm wide.",
                "When the flour paste has cooled but is not cold, start adding the egg, bit by bit, beating well between each addition until you have a smooth batter which will reluctantly drop off the end of your spoon (you can do this in a freestanding mixer if you have one). You may not need to use all the egg, so add it slowly. Transfer to your piping bag and use a little of the mixture to stick the parchment to your trays.",
                "Pipe the choux onto the baking sheet, using the lines as a guide. Pipe slowly so the eclairs aren’t too skinny – each one should be about 2.5cm wide x 12cm long. Bake for 35-40 mins, swapping the trays around for the final 10 mins. The choux should be puffed, golden and sound hollow when tapped. You may wish to sacrifice one eclair to make sure the inside is completely dried out – if it’s still moist, the eclair will sink when cooling. Once baked, leave to cool completely. (Can be made a day ahead and stored in an airtight container, reheat in the oven for 5-10 mins to crisp up before filling.) Split each eclair through the middle with a serrated knife.",
                },
                "3",
                "runway-eclairs-4198632.webp"),


                                new Recipe(
                "21",
                "Cheesy broccoli pasta bake",
                "7777",
                50,
                3,
                new DateTime(),
                new List<string>(){
                "280g penne",
                "280g broccoli",
                "25g butter",
                "25g plain flour",
                "300ml milk",
                "1 tbsp wholegrain mustard",
                "140g mature cheddar, grated",
                },
                new List<string>(){
                    "Cook the pasta, adding the broccoli for the final 4-5 mins and cooking until tender. Drain well, then heat the grill.",
                    "Heat the butter in a saucepan and stir in the flour. Cook for 1 min, then gradually add the milk, stirring well between each addition. Bring to the boil, stirring, then simmer for 2 mins, before stirring in the mustard, half the cheese and seasoning.",
                    "Mix the pasta and broccoli into the sauce and spoon into an ovenproof dish. Scatter over the remaining cheese and place under a hot grill for 3-4 mins until golden and bubbling.",
                },
                "1",
                "recipe-image-legacy-id-197477_10-8d45e07.webp"),

                                            new Recipe("22","Ginger & white chocolate cake","1111",65,5,new DateTime(),
                new List<string>(){ "220g unsalted butter ",
                    "220g unsalted butter",
                    "365g self-raising flour",
                    "200g muscovado sugar",
                    "50g black treacle",
                    "150g golden syrup",
                    "2 large eggs",
                    "300ml milk",
                    "½ tsp cinnamon",
                },
                new List<string>(){
                    "Heat the oven to 180C/160C fan/gas 4. Melt 1 tbsp butter in a small pan, then stir in ½ tbsp flour to create a wet paste. Brush it over the inside of a 9-inch bundt tin. Put the remaining butter, sugar, treacle and golden syrup in a pan set over a medium heat and stir until everything has melted together. Leave to cool a little.",
                    "Pour the mixture into a large bowl and whisk in the eggs and milk. Fold in the stem ginger, remaining flour, salt, ground ginger, cinnamon and bicarb. Tip into the prepared tin and bake for 40-45 mins, or until firm to the touch. Leave to cool for 10 mins in the tin, then turn out onto a wire rack to cool completely.",
                    "To make the icing, whisk the milk, ginger syrup and icing sugar together. Melt the chocolate in a heatproof bowl in the microwave in 1-min bursts. Leave to cool a little, then whisk into the milk mixture. Spoon the icing over the cake, then decorate with the crystallised ginger pieces."
                },"1","ginger-and-white-choc-cake-2903ae9.webp"),


            new Recipe(
                "23",
                "bean soup",
                "4444",
                10,
                1,
                new DateTime(),
                new List<string>(){
                "4 tsp olive oil",
                "500g leeks",
                "4 thyme sprigs",
                "2 x 400g cans butter beans",
                "500ml vegetable bouillon stock",
                "2 tsp wholegrain mustard",
                "½ small pack flat-leaf parsley",
                "3 rashers streaky bacon",
                },
                new List<string>(){
                "Heat 1 tbsp oil in a large saucepan over a low heat. Add the leeks, thyme and seasoning. Cover and cook for 15 mins until softened, adding a splash of water if the leeks start to stick. Add the butter beans with the water from the cans, the stock and mustard. Bring to the boil and simmer for 3-4 mins until hot. Blend the soup in a food processor or with a stick blender, stir through the parsley and check the seasoning.",
                "Put the bacon in a large, non-stick frying pan over a medium heat. Cook for 3-4 mins until crispy, then set side to cool. Add the remaining 1 tsp oil to the pan, and tip in the kale and hazelnuts. Cook for 2 mins, stirring until the kale is wilted and crisping at the edges and the hazelnuts are toasted. Cut the bacon into small pieces, then stir into the kale mixture.",
                "Reheat the soup, adding a splash of water if it is too thick. Serve in bowls sprinkled with the bacon & kale mixture.",
                },
                "2",
                "leek-butter-bean-soup-b4d5048.webp"),


                new Recipe(
                "24",
                "Choux pastry recipes",
                "6666",
                130,
                5,
                new DateTime(),
                new List<string>(){
                "170g lightly salted butter",
                "200g plain flour",
                "5 medium eggs",
                "300ml milk",
                "150ml double cream",
                "3 egg yolks",
                "50g white caster sugar",
                },
                new List<string>(){
                "First, make the choux pastry. Put the butter in a saucepan with 450ml water. Sieve the flour into a large bowl and set aside. Bring the butter and water to a fast boil, simmer until the butter has melted, then tip in the flour and beat like mad with a wooden spoon until the mixture pulls away from the sides of the pan and is lump-free. Tip into the bowl and spread the thick paste up the sides a little to help it cool quickly, then leave for 10 mins.",
                "Heat oven to 200C/180C fan/ gas 6 and cut two pieces of baking parchment to fit two baking sheets. Using a ruler and pen, mark 10 lines about 12cm long over each piece, leaving plenty of space between the lines, then flip the parchment over. Fit a piping bag with a large round piping nozzle, about 1.5cm wide.",
                "When the flour paste has cooled but is not cold, start adding the egg, bit by bit, beating well between each addition until you have a smooth batter which will reluctantly drop off the end of your spoon (you can do this in a freestanding mixer if you have one). You may not need to use all the egg, so add it slowly. Transfer to your piping bag and use a little of the mixture to stick the parchment to your trays.",
                "Pipe the choux onto the baking sheet, using the lines as a guide. Pipe slowly so the eclairs aren’t too skinny – each one should be about 2.5cm wide x 12cm long. Bake for 35-40 mins, swapping the trays around for the final 10 mins. The choux should be puffed, golden and sound hollow when tapped. You may wish to sacrifice one eclair to make sure the inside is completely dried out – if it’s still moist, the eclair will sink when cooling. Once baked, leave to cool completely. (Can be made a day ahead and stored in an airtight container, reheat in the oven for 5-10 mins to crisp up before filling.) Split each eclair through the middle with a serrated knife.",
                },
                "3",
                "runway-eclairs-4198632.webp"),


                                new Recipe(
                "25",
                "Cheesy broccoli pasta bake",
                "7777",
                50,
                3,
                new DateTime(),
                new List<string>(){
                "280g penne",
                "280g broccoli",
                "25g butter",
                "25g plain flour",
                "300ml milk",
                "1 tbsp wholegrain mustard",
                "140g mature cheddar, grated",
                },
                new List<string>(){
                    "Cook the pasta, adding the broccoli for the final 4-5 mins and cooking until tender. Drain well, then heat the grill.",
                    "Heat the butter in a saucepan and stir in the flour. Cook for 1 min, then gradually add the milk, stirring well between each addition. Bring to the boil, stirring, then simmer for 2 mins, before stirring in the mustard, half the cheese and seasoning.",
                    "Mix the pasta and broccoli into the sauce and spoon into an ovenproof dish. Scatter over the remaining cheese and place under a hot grill for 3-4 mins until golden and bubbling.",
                },
                "1",
                "recipe-image-legacy-id-197477_10-8d45e07.webp"),

        };
        public static List<Category> CategoryList { get; set; } = new List<Category>()
        {
            new Category("1111","cakes","🎂"),
            new Category("2222","desserts","🍦"),
            new Category("3333","salads","🥗"),
            new Category("4444","soups","🥣"),
            new Category("5555","special courses","🍗"),
            new Category("6666","sweets","🍹"),
            new Category("7777","pastries","🥐")

        };

        public DB()
        {

        }
    }
}
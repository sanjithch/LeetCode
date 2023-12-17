 Dictionary<string, Dictionary<string, int>> menu = new Dictionary<string, Dictionary<string, int>>();

// Menu Contains Cusines and foods, 
// foods contain food and rating
    public FoodRatings(string[] foods, string[] cuisines, int[] ratings) {
        int n = foods.Length;
        for(int i=0;i<n;i++){
            if(menu.ContainsKey(cuisines[i])){
                menu[cuisines[i]].Add(foods[i], ratings[i]);
            }
            else{
                Dictionary<string, int> temp = new Dictionary<string, int>();
                temp.Add(foods[i], ratings[i]);
                menu.Add(cuisines[i], temp);
            }
        }

    }
    
    public void ChangeRating(string food, int newRating) {
        foreach(var items in menu){
            if(items.Value.ContainsKey(food)){
                items.Value[food] = newRating;
            }
        }
    }
    
    public string HighestRated(string cuisine) {
        string bestFood = "";
        int rating = 0;

        foreach(var item in menu[cuisine]){
            if(item.Value==rating){
                if(String.Compare(item.Key, bestFood)<0){
                    bestFood = item.Key;
                }
            }
            else if(item.Value > rating){
                rating = item.Value;
                bestFood = item.Key;
            }
        }

        return bestFood;
    }

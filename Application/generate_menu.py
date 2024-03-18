import csv
import random

# Define categories and items
categories = ['Desi', 'Fast Food', 'Dessert', 'Juices', 'Continental']
items = {
    'Desi': ['Biryani', 'Karahi Chicken', 'Seekh Kebab', 'Nihari', 'Chicken Tikka', 'Haleem', 'Chapli Kebab', 'Aloo Gosht', 'Daal Chawal', 'Chicken Handi', 'Rogan Josh', 'Saag', 'Chicken Korma', 'Chicken Karahi', 'Mutton Pulao', 'Keema', 'Bhindi Gosht', 'Mutton Kunna', 'Daal Makhani', 'Chicken Malai Boti', 'Reshmi Kebab', 'Tandoori Roti', 'Bhuna Gosht', 'Chicken Bihari'],
    'Fast Food': ['Burgers', 'Chicken Nuggets', 'French Fries', 'Chicken Sandwich', 'Pizza', 'Burrito', 'Fried Chicken', 'Chicken Tenders', 'Onion Rings', 'Egg Rolls'],
    'Dessert': ['Sundae', 'Milkshake', 'Ice Cream Cone', 'Brownie', 'Cookie', 'Apple Pie', 'Cheesecake', 'Donut', 'Cupcake', 'Muffin'],
    'Juices': ['Orange Juice', 'Apple Juice', 'Cranberry Juice', 'Grape Juice', 'Pineapple Juice', 'Mango Juice', 'Watermelon Juice', 'Coconut Water', 'Seasonal Juice'],
    'Continental': ['Spaghetti Bolognese', 'Beef Stroganoff', 'Chicken Alfredo Pasta', 'Fish and Chips', 'Vegetable Lasagna', 'Mushroom Risotto', 'Chicken Fajitas', 'Beef Steak', 'Salad', 'Beef Tacos', 'Beef Chili', 'Cheesecake']
}

# Generate random prices for items (in rupees)
price_range = (50, 500)  # Define the range of prices
item_prices = {item: round(random.uniform(price_range[0], price_range[1]), 2) for category_items in items.values() for item in category_items}

# Write data to CSV
csv_file_path = 'menu_items.csv'
with open(csv_file_path, 'w', newline='') as csv_file:
    writer = csv.writer(csv_file)
    writer.writerow(['ItemName', 'Category', 'Price (Rs)'])
    for category, category_items in items.items():
        for item in category_items:
            writer.writerow([item, category, item_prices[item]])

print("CSV file with menu items generated:", csv_file_path)

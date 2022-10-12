import csv

with open('/home/???/Documents/statistics2/dataset/MyApp/music.csv', 'r') as csv_file:
    reader = csv.reader(csv_file)
    for row in reader:
        print(row[2])
    csv_file.close()



# import pandas
# df = pandas.read_csv('/home/niloufar/Documents/statistics2/dataset/MyApp/music.csv', index_col='genre')
# print(df)


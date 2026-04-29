def iteracja(n): 
    a = 0 
    b = 1
    licznik = 0
    
    while licznik < n: 
        nowa_liczba = a + b 
        a = b
        b = nowa_liczba
        licznik = licznik + 1
    return a 
def rekurencja(n): 
    while True:
     if n <= 1:
        return n 
     return rekurencja(n-1) + rekurencja(n-2) 
n = int(input("Podaj wartość n: "))
print(f"Wynik z iteracji: {iteracja(n)}") 
print(f"Wynik z rekurencji: {rekurencja(n)}")
 
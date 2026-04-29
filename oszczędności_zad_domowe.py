def stopa_procentowa(saldo): 
    if saldo < 0:
        return 0.03213
    elif saldo < 1000:      
        return 0.005 
    elif saldo >= 1000 and saldo < 5000:
        return 0.01621
    elif saldo >= 5000:
        return 0.02475
def odsetki(saldo):
    stawka = stopa_procentowa(saldo) 
    return saldo * stawka
def aktualizacja_salda_rocznego(saldo):
    return saldo + odsetki(saldo)
def ile_lat_przed_oczekiwanym_saldem(saldo, docelowe_saldo):
    lata = 0  
    while saldo < docelowe_saldo: 
        saldo = aktualizacja_salda_rocznego(saldo)
        lata = lata + 1
        return lata
saldo = float(input("Podaj kwote oszczędności: ")) 

print(f"Saldo: {saldo}")
print(f"Odsetki: {odsetki(saldo)}")
print(f"Zaktualizowane saldo: {aktualizacja_salda_rocznego(saldo)}")
print(f"Lata do osiągnięcia 1000: {ile_lat_przed_oczekiwanym_saldem(saldo, 1000)}")
USE moja_videoteka
SELECT nazovi_prijatelji.ime,
nazovi_prijatelji.prezime, 
DATEDIFF(d, posudba.posudba,GETDATE())as nijevratioDana
FROM posudba  
LEFT JOIN nazovi_prijatelji 
ON id=nazovi_prijatelj_id
WHERE vracanje IS NULL




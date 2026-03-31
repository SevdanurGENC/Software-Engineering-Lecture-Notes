package com.nano.unittest.customer;
 
import java.util.HashMap;
import java.util.Map;

public class MusteriRepositoryStub extends MusteriRepository{

	private Map<Integer, Musteri> musteriListesi = new HashMap<Integer, Musteri>();
	
	@Override
	public void kaydet(Musteri musteri) {
		musteriListesi.put(musteri.getId(), musteri);
	}
	
	@Override
	public void sil(Integer musteriID) {
		musteriListesi.remove(musteriID);
		
	}
	
	@Override
	public Musteri bul(Integer musteriID) {
		return musteriListesi.get(musteriID);
		
	}
	
//	public  Map<Integer, Musteri> getMusterListesi(){
//		return musteriListesi;
//	}
	
	
	public void herseyiSil() {
		musteriListesi.clear();
	}
	
	
	
	
	
	
	
	
	
	
	
	   
}

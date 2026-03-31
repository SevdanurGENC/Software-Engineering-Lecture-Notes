package com.nano.unittest.customer;

public class MusteriRepository {
	
	public void kaydet(Musteri musteri) {
		System.out.println("Kaydedildi.");
	}

	public void sil(Integer musteriID) {
		System.out.println("Musteri Silindi.");
	}

	public Musteri bul(Integer musteriID) {
		System.out.println("Musteri Bulundu.");
		return null;
	}
	
}

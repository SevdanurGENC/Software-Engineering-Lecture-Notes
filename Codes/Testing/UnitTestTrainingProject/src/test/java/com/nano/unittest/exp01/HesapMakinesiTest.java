package com.nano.unittest.exp01;

import static org.junit.Assert.*;

import org.junit.Test;

import com.nano.unittest.exp01.HesapMakinesi;

import junit.framework.Assert;

public class HesapMakinesiTest {
	
	@Test
	public void testTopla() throws Exception {
		// GIVEN : on hazirlik
		HesapMakinesi hesapMakinesi = new HesapMakinesi();
		int sayi1=5, sayi2=19;
		
		// WHEN : test edilen metod calistirilir
		int toplam = hesapMakinesi.topla(sayi1, sayi2); 
		// THEN : sonucu kontrol et 
		Assert.assertEquals(24, toplam);  		
	} 
	
	@Test
	public void testCikart() throws Exception {
		HesapMakinesi hesapMakinesi = new HesapMakinesi();
		Assert.assertEquals(20, hesapMakinesi.cikar(50,30));		
	}
	
	@Test
	public void testSifirdanCikincaEksiOlur() throws Exception {
		HesapMakinesi hesapMakinesi = new HesapMakinesi();
		Assert.assertEquals(-15, hesapMakinesi.cikar(0,15));
		
	}
	
	@Test
	public void testSayidanSifirCikincaAyniSayiKalir() throws Exception {
		HesapMakinesi hesapMakinesi = new HesapMakinesi();
		Assert.assertEquals(15, hesapMakinesi.cikar(15,0));  
		
	}  
}

package com.nano.unittest.junit;

import static org.junit.Assert.*;

import java.util.Arrays;
import java.util.Collection;

import org.junit.*;
import org.junit.runner.RunWith;
import org.junit.runners.Parameterized;

import com.nano.unittest.exp01.HesapMakinesi;

@RunWith(Parameterized.class)
public class ParametreTest {

	private HesapMakinesi hesapMakinesi = new HesapMakinesi();
	
	@Parameterized.Parameters
	public static Collection<Object[]> data(){
		return Arrays.asList(new Object[][] {  
		{10,2,20},
		{20,2,40},
		{5,2,10},
		{24,2,48},
		{6,2,12}});
	}
	
	private int eni, boyu, toplamMetreKare;
	
	public ParametreTest(int eni, int boyu, int toplamMetreKare) {
		this.eni = eni;
		this.boyu = boyu;
		this.toplamMetreKare = toplamMetreKare;

	}
	
	@Test
	public void testMetreKareHesapla() throws Exception{
		assertEquals(toplamMetreKare, hesapMakinesi.metreKareHesapla(eni, boyu));
		
	}
}

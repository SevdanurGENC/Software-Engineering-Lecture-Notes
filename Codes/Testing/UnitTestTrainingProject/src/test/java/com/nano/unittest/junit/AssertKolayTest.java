package com.nano.unittest.junit;

import static org.junit.Assert.assertEquals;

import java.util.Arrays;
import java.util.Collection;

import junitparams.JUnitParamsRunner;
import junitparams.Parameters;
import org.junit.Test;
import org.junit.runner.RunWith; 

import com.nano.unittest.exp01.HesapMakinesi;

@RunWith(JUnitParamsRunner.class)
public class AssertKolayTest {
	private HesapMakinesi hesapMakinesi = new HesapMakinesi();
	  
	@Test
	@Parameters({"10,2,20","20,2,40","5,2,10","24,2,48","6,2,12"})
	public void testMetreKareHesapla(int eni, int boyu, int toplamMetreKare) throws Exception{
		assertEquals(toplamMetreKare, hesapMakinesi.metreKareHesapla(eni, boyu));
		
	}

}

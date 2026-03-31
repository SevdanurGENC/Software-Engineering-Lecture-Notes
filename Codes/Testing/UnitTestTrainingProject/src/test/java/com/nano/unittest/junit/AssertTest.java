package com.nano.unittest.junit;

import static org.junit.Assert.assertArrayEquals;
import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertNotNull;
import static org.junit.Assert.assertNull;
import static org.junit.Assert.assertSame;
import static org.junit.Assert.assertTrue;

import org.junit.*;

public class AssertTest {
	
	@Test
	public void testAssertions() throws Exception{
		//Dummy d1 = new Dummy(5);
		//Dummy d2 = new Dummy(5);
		
		//assertEquals(d1,d2);
		
		/**
         * Hepsinin soluna hata mesajı eklenebilir.  Veya olmadan kullanılabilir.
         */
		
		//Dummy d2 = d1;
		//assertSame("d1 d2'ye esit olmalidir",d1, d2);
		
//		Dummy d1 = null;
//		Dummy d2 = new Dummy(5);
//		assertNull(d1);
//		assertNotNull(d2);
//		assertTrue(d1 == null);
//		assertTrue(d2.equals(d1));
		
		String[] arr1 = new String[] {"1","2"};
		String[] arr2 = new String[] {"1","2"};
		
		assertArrayEquals(arr1, arr2);
		
	}
	
	private static class Dummy{
		private int id;
		
		public int getId() {
			return id;			
		}
		
		public Dummy(int id) {
			this.id = id;
		} 
		/**
         * Normalde iki nesne eşit olmaz.
         * Eşitlik durumunda idler ile karşılaştırma yapmasını sağlıyoruz.
         */
		
//		@Override
//		public boolean equals(Object obj) {
//			return this.id == ((Dummy) obj).getId();
//		}
	} 
}

package com.nano.unittest.customer.exception;

public class MailServerUnavailableException extends RuntimeException{
	
	public MailServerUnavailableException(String message) {
		super(message);
	}

}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 3.3.1.7705
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// $ANTLR 3.3.1.7705 Lexer1.g3 2011-06-13 22:04:20

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162


using System.Collections.Generic;
using Antlr.Runtime;

namespace NaiveTiger
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3.1.7705")]
[System.CLSCompliant(false)]
public partial class Lexer1 : Antlr.Runtime.Lexer
{
	public const int EOF=-1;
	public const int BlockComment=4;
	public const int Identifier=5;
	public const int IntegerLiteral=6;
	public const int LineComment=7;
	public const int Other=8;
	public const int ReservedWord=9;
	public const int StringLiteral=10;
	public const int WhiteSpace=11;

    // delegates
    // delegators

	public Lexer1()
	{
		OnCreated();
	}

	public Lexer1(ICharStream input )
		: this(input, new RecognizerSharedState())
	{
	}

	public Lexer1(ICharStream input, RecognizerSharedState state)
		: base(input, state)
	{


		OnCreated();
	}
	public override string GrammarFileName { get { return "Lexer1.g3"; } }


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	partial void EnterRule_ReservedWord();
	partial void LeaveRule_ReservedWord();

	// $ANTLR start "ReservedWord"
	[GrammarRule("ReservedWord")]
	private void mReservedWord()
	{
		EnterRule_ReservedWord();
		EnterRule("ReservedWord", 1);
		TraceIn("ReservedWord", 1);
		try
		{
			int _type = ReservedWord;
			int _channel = DefaultTokenChannel;
			// Lexer1.g3:13:2: ( 'array' | 'break' | 'do' | 'else' | 'end' | 'for' | 'function' | 'if' | 'in' | 'let' | 'nil' | 'of' | 'then' | 'to' | 'type' | 'var' | 'while' | 'int' | 'string' )
			int alt1=19;
			try { DebugEnterDecision(1, false);
			try
			{
				alt1 = dfa1.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(1); }
			switch (alt1)
			{
			case 1:
				DebugEnterAlt(1);
				// Lexer1.g3:13:4: 'array'
				{
				DebugLocation(13, 4);
				Match("array"); 


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Lexer1.g3:14:4: 'break'
				{
				DebugLocation(14, 4);
				Match("break"); 


				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Lexer1.g3:15:4: 'do'
				{
				DebugLocation(15, 4);
				Match("do"); 


				}
				break;
			case 4:
				DebugEnterAlt(4);
				// Lexer1.g3:16:4: 'else'
				{
				DebugLocation(16, 4);
				Match("else"); 


				}
				break;
			case 5:
				DebugEnterAlt(5);
				// Lexer1.g3:17:4: 'end'
				{
				DebugLocation(17, 4);
				Match("end"); 


				}
				break;
			case 6:
				DebugEnterAlt(6);
				// Lexer1.g3:18:4: 'for'
				{
				DebugLocation(18, 4);
				Match("for"); 


				}
				break;
			case 7:
				DebugEnterAlt(7);
				// Lexer1.g3:19:4: 'function'
				{
				DebugLocation(19, 4);
				Match("function"); 


				}
				break;
			case 8:
				DebugEnterAlt(8);
				// Lexer1.g3:20:4: 'if'
				{
				DebugLocation(20, 4);
				Match("if"); 


				}
				break;
			case 9:
				DebugEnterAlt(9);
				// Lexer1.g3:21:4: 'in'
				{
				DebugLocation(21, 4);
				Match("in"); 


				}
				break;
			case 10:
				DebugEnterAlt(10);
				// Lexer1.g3:22:4: 'let'
				{
				DebugLocation(22, 4);
				Match("let"); 


				}
				break;
			case 11:
				DebugEnterAlt(11);
				// Lexer1.g3:23:4: 'nil'
				{
				DebugLocation(23, 4);
				Match("nil"); 


				}
				break;
			case 12:
				DebugEnterAlt(12);
				// Lexer1.g3:24:4: 'of'
				{
				DebugLocation(24, 4);
				Match("of"); 


				}
				break;
			case 13:
				DebugEnterAlt(13);
				// Lexer1.g3:25:4: 'then'
				{
				DebugLocation(25, 4);
				Match("then"); 


				}
				break;
			case 14:
				DebugEnterAlt(14);
				// Lexer1.g3:26:4: 'to'
				{
				DebugLocation(26, 4);
				Match("to"); 


				}
				break;
			case 15:
				DebugEnterAlt(15);
				// Lexer1.g3:27:4: 'type'
				{
				DebugLocation(27, 4);
				Match("type"); 


				}
				break;
			case 16:
				DebugEnterAlt(16);
				// Lexer1.g3:28:4: 'var'
				{
				DebugLocation(28, 4);
				Match("var"); 


				}
				break;
			case 17:
				DebugEnterAlt(17);
				// Lexer1.g3:29:4: 'while'
				{
				DebugLocation(29, 4);
				Match("while"); 


				}
				break;
			case 18:
				DebugEnterAlt(18);
				// Lexer1.g3:30:4: 'int'
				{
				DebugLocation(30, 4);
				Match("int"); 


				}
				break;
			case 19:
				DebugEnterAlt(19);
				// Lexer1.g3:31:4: 'string'
				{
				DebugLocation(31, 4);
				Match("string"); 


				}
				break;

			}
			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ReservedWord", 1);
			LeaveRule("ReservedWord", 1);
			LeaveRule_ReservedWord();
		}
	}
	// $ANTLR end "ReservedWord"

	partial void EnterRule_Identifier();
	partial void LeaveRule_Identifier();

	// $ANTLR start "Identifier"
	[GrammarRule("Identifier")]
	private void mIdentifier()
	{
		EnterRule_Identifier();
		EnterRule("Identifier", 2);
		TraceIn("Identifier", 2);
		try
		{
			int _type = Identifier;
			int _channel = DefaultTokenChannel;
			// Lexer1.g3:59:11: ( ( 'a' .. 'z' | 'A' .. 'Z' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )* )
			DebugEnterAlt(1);
			// Lexer1.g3:59:12: ( 'a' .. 'z' | 'A' .. 'Z' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )*
			{
			DebugLocation(59, 12);
			if ((input.LA(1)>='A' && input.LA(1)<='Z')||(input.LA(1)>='a' && input.LA(1)<='z'))
			{
				input.Consume();

			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;}

			DebugLocation(59, 33);
			// Lexer1.g3:59:33: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )*
			try { DebugEnterSubRule(2);
			while (true)
			{
				int alt2=2;
				try { DebugEnterDecision(2, false);
				int LA2_0 = input.LA(1);

				if (((LA2_0>='0' && LA2_0<='9')||(LA2_0>='A' && LA2_0<='Z')||LA2_0=='_'||(LA2_0>='a' && LA2_0<='z')))
				{
					alt2 = 1;
				}


				} finally { DebugExitDecision(2); }
				switch ( alt2 )
				{
				case 1:
					DebugEnterAlt(1);
					// Lexer1.g3:
					{
					DebugLocation(59, 33);
					input.Consume();


					}
					break;

				default:
					goto loop2;
				}
			}

			loop2:
				;

			} finally { DebugExitSubRule(2); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("Identifier", 2);
			LeaveRule("Identifier", 2);
			LeaveRule_Identifier();
		}
	}
	// $ANTLR end "Identifier"

	partial void EnterRule_IntegerLiteral();
	partial void LeaveRule_IntegerLiteral();

	// $ANTLR start "IntegerLiteral"
	[GrammarRule("IntegerLiteral")]
	private void mIntegerLiteral()
	{
		EnterRule_IntegerLiteral();
		EnterRule("IntegerLiteral", 3);
		TraceIn("IntegerLiteral", 3);
		try
		{
			int _type = IntegerLiteral;
			int _channel = DefaultTokenChannel;
			// Lexer1.g3:61:15: ( ( '0' .. '9' )+ )
			DebugEnterAlt(1);
			// Lexer1.g3:61:16: ( '0' .. '9' )+
			{
			DebugLocation(61, 16);
			// Lexer1.g3:61:16: ( '0' .. '9' )+
			int cnt3=0;
			try { DebugEnterSubRule(3);
			while (true)
			{
				int alt3=2;
				try { DebugEnterDecision(3, false);
				int LA3_0 = input.LA(1);

				if (((LA3_0>='0' && LA3_0<='9')))
				{
					alt3 = 1;
				}


				} finally { DebugExitDecision(3); }
				switch (alt3)
				{
				case 1:
					DebugEnterAlt(1);
					// Lexer1.g3:
					{
					DebugLocation(61, 16);
					input.Consume();


					}
					break;

				default:
					if (cnt3 >= 1)
						goto loop3;

					EarlyExitException eee3 = new EarlyExitException( 3, input );
					DebugRecognitionException(eee3);
					throw eee3;
				}
				cnt3++;
			}
			loop3:
				;

			} finally { DebugExitSubRule(3); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("IntegerLiteral", 3);
			LeaveRule("IntegerLiteral", 3);
			LeaveRule_IntegerLiteral();
		}
	}
	// $ANTLR end "IntegerLiteral"

	partial void EnterRule_StringLiteral();
	partial void LeaveRule_StringLiteral();

	// $ANTLR start "StringLiteral"
	[GrammarRule("StringLiteral")]
	private void mStringLiteral()
	{
		EnterRule_StringLiteral();
		EnterRule("StringLiteral", 4);
		TraceIn("StringLiteral", 4);
		try
		{
			int _type = StringLiteral;
			int _channel = DefaultTokenChannel;
			// Lexer1.g3:63:14: ( '\"' ( '\\\\' . |~ ( '\\\\' | '\"' ) )* '\"' )
			DebugEnterAlt(1);
			// Lexer1.g3:63:15: '\"' ( '\\\\' . |~ ( '\\\\' | '\"' ) )* '\"'
			{
			DebugLocation(63, 15);
			Match('\"'); 
			DebugLocation(63, 19);
			// Lexer1.g3:63:19: ( '\\\\' . |~ ( '\\\\' | '\"' ) )*
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=3;
				try { DebugEnterDecision(4, false);
				int LA4_0 = input.LA(1);

				if ((LA4_0=='\\'))
				{
					alt4 = 1;
				}
				else if (((LA4_0>='\u0000' && LA4_0<='!')||(LA4_0>='#' && LA4_0<='[')||(LA4_0>=']' && LA4_0<='\uFFFF')))
				{
					alt4 = 2;
				}


				} finally { DebugExitDecision(4); }
				switch ( alt4 )
				{
				case 1:
					DebugEnterAlt(1);
					// Lexer1.g3:63:21: '\\\\' .
					{
					DebugLocation(63, 21);
					Match('\\'); 
					DebugLocation(63, 26);
					MatchAny(); 

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// Lexer1.g3:63:30: ~ ( '\\\\' | '\"' )
					{
					DebugLocation(63, 30);
					input.Consume();


					}
					break;

				default:
					goto loop4;
				}
			}

			loop4:
				;

			} finally { DebugExitSubRule(4); }

			DebugLocation(63, 47);
			Match('\"'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("StringLiteral", 4);
			LeaveRule("StringLiteral", 4);
			LeaveRule_StringLiteral();
		}
	}
	// $ANTLR end "StringLiteral"

	partial void EnterRule_WhiteSpace();
	partial void LeaveRule_WhiteSpace();

	// $ANTLR start "WhiteSpace"
	[GrammarRule("WhiteSpace")]
	private void mWhiteSpace()
	{
		EnterRule_WhiteSpace();
		EnterRule("WhiteSpace", 5);
		TraceIn("WhiteSpace", 5);
		try
		{
			int _type = WhiteSpace;
			int _channel = DefaultTokenChannel;
			// Lexer1.g3:65:11: ( ( ' ' | '\\t' | '\\r' | '\\n' )+ )
			DebugEnterAlt(1);
			// Lexer1.g3:65:12: ( ' ' | '\\t' | '\\r' | '\\n' )+
			{
			DebugLocation(65, 12);
			// Lexer1.g3:65:12: ( ' ' | '\\t' | '\\r' | '\\n' )+
			int cnt5=0;
			try { DebugEnterSubRule(5);
			while (true)
			{
				int alt5=2;
				try { DebugEnterDecision(5, false);
				int LA5_0 = input.LA(1);

				if (((LA5_0>='\t' && LA5_0<='\n')||LA5_0=='\r'||LA5_0==' '))
				{
					alt5 = 1;
				}


				} finally { DebugExitDecision(5); }
				switch (alt5)
				{
				case 1:
					DebugEnterAlt(1);
					// Lexer1.g3:
					{
					DebugLocation(65, 12);
					input.Consume();


					}
					break;

				default:
					if (cnt5 >= 1)
						goto loop5;

					EarlyExitException eee5 = new EarlyExitException( 5, input );
					DebugRecognitionException(eee5);
					throw eee5;
				}
				cnt5++;
			}
			loop5:
				;

			} finally { DebugExitSubRule(5); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WhiteSpace", 5);
			LeaveRule("WhiteSpace", 5);
			LeaveRule_WhiteSpace();
		}
	}
	// $ANTLR end "WhiteSpace"

	partial void EnterRule_BlockComment();
	partial void LeaveRule_BlockComment();

	// $ANTLR start "BlockComment"
	[GrammarRule("BlockComment")]
	private void mBlockComment()
	{
		EnterRule_BlockComment();
		EnterRule("BlockComment", 6);
		TraceIn("BlockComment", 6);
		try
		{
			int _type = BlockComment;
			int _channel = DefaultTokenChannel;
			// Lexer1.g3:67:13: ( '/*' ( options {greedy=false; } : ( BlockComment | . ) )* '*/' )
			DebugEnterAlt(1);
			// Lexer1.g3:67:14: '/*' ( options {greedy=false; } : ( BlockComment | . ) )* '*/'
			{
			DebugLocation(67, 14);
			Match("/*"); 

			DebugLocation(67, 19);
			// Lexer1.g3:67:19: ( options {greedy=false; } : ( BlockComment | . ) )*
			try { DebugEnterSubRule(7);
			while (true)
			{
				int alt7=2;
				try { DebugEnterDecision(7, false);
				int LA7_0 = input.LA(1);

				if ((LA7_0=='*'))
				{
					int LA7_1 = input.LA(2);

					if ((LA7_1=='/'))
					{
						alt7 = 2;
					}
					else if (((LA7_1>='\u0000' && LA7_1<='.')||(LA7_1>='0' && LA7_1<='\uFFFF')))
					{
						alt7 = 1;
					}


				}
				else if (((LA7_0>='\u0000' && LA7_0<=')')||(LA7_0>='+' && LA7_0<='\uFFFF')))
				{
					alt7 = 1;
				}


				} finally { DebugExitDecision(7); }
				switch ( alt7 )
				{
				case 1:
					DebugEnterAlt(1);
					// Lexer1.g3:67:51: ( BlockComment | . )
					{
					DebugLocation(67, 51);
					// Lexer1.g3:67:51: ( BlockComment | . )
					int alt6=2;
					try { DebugEnterSubRule(6);
					try { DebugEnterDecision(6, false);
					int LA6_0 = input.LA(1);

					if ((LA6_0=='/'))
					{
						int LA6_1 = input.LA(2);

						if ((LA6_1=='*'))
						{
							alt6 = 1;
						}
						else if (((LA6_1>='\u0000' && LA6_1<=')')||(LA6_1>='+' && LA6_1<='\uFFFF')))
						{
							alt6 = 2;
						}
						else
						{
							NoViableAltException nvae = new NoViableAltException("", 6, 1, input);
							DebugRecognitionException(nvae);
							throw nvae;
						}
					}
					else if (((LA6_0>='\u0000' && LA6_0<='.')||(LA6_0>='0' && LA6_0<='\uFFFF')))
					{
						alt6 = 2;
					}
					else
					{
						NoViableAltException nvae = new NoViableAltException("", 6, 0, input);
						DebugRecognitionException(nvae);
						throw nvae;
					}
					} finally { DebugExitDecision(6); }
					switch (alt6)
					{
					case 1:
						DebugEnterAlt(1);
						// Lexer1.g3:67:53: BlockComment
						{
						DebugLocation(67, 53);
						mBlockComment(); 

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// Lexer1.g3:67:68: .
						{
						DebugLocation(67, 68);
						MatchAny(); 

						}
						break;

					}
					} finally { DebugExitSubRule(6); }


					}
					break;

				default:
					goto loop7;
				}
			}

			loop7:
				;

			} finally { DebugExitSubRule(7); }

			DebugLocation(67, 75);
			Match("*/"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("BlockComment", 6);
			LeaveRule("BlockComment", 6);
			LeaveRule_BlockComment();
		}
	}
	// $ANTLR end "BlockComment"

	partial void EnterRule_LineComment();
	partial void LeaveRule_LineComment();

	// $ANTLR start "LineComment"
	[GrammarRule("LineComment")]
	private void mLineComment()
	{
		EnterRule_LineComment();
		EnterRule("LineComment", 7);
		TraceIn("LineComment", 7);
		try
		{
			int _type = LineComment;
			int _channel = DefaultTokenChannel;
			// Lexer1.g3:69:12: ( '//' (~ ( '\\n' | '\\r' ) )* )
			DebugEnterAlt(1);
			// Lexer1.g3:69:13: '//' (~ ( '\\n' | '\\r' ) )*
			{
			DebugLocation(69, 13);
			Match("//"); 

			DebugLocation(69, 18);
			// Lexer1.g3:69:18: (~ ( '\\n' | '\\r' ) )*
			try { DebugEnterSubRule(8);
			while (true)
			{
				int alt8=2;
				try { DebugEnterDecision(8, false);
				int LA8_0 = input.LA(1);

				if (((LA8_0>='\u0000' && LA8_0<='\t')||(LA8_0>='\u000B' && LA8_0<='\f')||(LA8_0>='\u000E' && LA8_0<='\uFFFF')))
				{
					alt8 = 1;
				}


				} finally { DebugExitDecision(8); }
				switch ( alt8 )
				{
				case 1:
					DebugEnterAlt(1);
					// Lexer1.g3:
					{
					DebugLocation(69, 18);
					input.Consume();


					}
					break;

				default:
					goto loop8;
				}
			}

			loop8:
				;

			} finally { DebugExitSubRule(8); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LineComment", 7);
			LeaveRule("LineComment", 7);
			LeaveRule_LineComment();
		}
	}
	// $ANTLR end "LineComment"

	partial void EnterRule_Other();
	partial void LeaveRule_Other();

	// $ANTLR start "Other"
	[GrammarRule("Other")]
	private void mOther()
	{
		EnterRule_Other();
		EnterRule("Other", 8);
		TraceIn("Other", 8);
		try
		{
			int _type = Other;
			int _channel = DefaultTokenChannel;
			// Lexer1.g3:71:6: ( . )
			DebugEnterAlt(1);
			// Lexer1.g3:71:7: .
			{
			DebugLocation(71, 7);
			MatchAny(); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("Other", 8);
			LeaveRule("Other", 8);
			LeaveRule_Other();
		}
	}
	// $ANTLR end "Other"

	public override void mTokens()
	{
		// Lexer1.g3:1:8: ( ReservedWord | Identifier | IntegerLiteral | StringLiteral | WhiteSpace | BlockComment | LineComment | Other )
		int alt9=8;
		try { DebugEnterDecision(9, false);
		try
		{
			alt9 = dfa9.Predict(input);
		}
		catch (NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
			throw;
		}
		} finally { DebugExitDecision(9); }
		switch (alt9)
		{
		case 1:
			DebugEnterAlt(1);
			// Lexer1.g3:1:10: ReservedWord
			{
			DebugLocation(1, 10);
			mReservedWord(); 

			}
			break;
		case 2:
			DebugEnterAlt(2);
			// Lexer1.g3:1:23: Identifier
			{
			DebugLocation(1, 23);
			mIdentifier(); 

			}
			break;
		case 3:
			DebugEnterAlt(3);
			// Lexer1.g3:1:34: IntegerLiteral
			{
			DebugLocation(1, 34);
			mIntegerLiteral(); 

			}
			break;
		case 4:
			DebugEnterAlt(4);
			// Lexer1.g3:1:49: StringLiteral
			{
			DebugLocation(1, 49);
			mStringLiteral(); 

			}
			break;
		case 5:
			DebugEnterAlt(5);
			// Lexer1.g3:1:63: WhiteSpace
			{
			DebugLocation(1, 63);
			mWhiteSpace(); 

			}
			break;
		case 6:
			DebugEnterAlt(6);
			// Lexer1.g3:1:74: BlockComment
			{
			DebugLocation(1, 74);
			mBlockComment(); 

			}
			break;
		case 7:
			DebugEnterAlt(7);
			// Lexer1.g3:1:87: LineComment
			{
			DebugLocation(1, 87);
			mLineComment(); 

			}
			break;
		case 8:
			DebugEnterAlt(8);
			// Lexer1.g3:1:99: Other
			{
			DebugLocation(1, 99);
			mOther(); 

			}
			break;

		}

	}


	#region DFA
	DFA1 dfa1;
	DFA9 dfa9;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa1 = new DFA1(this);
		dfa9 = new DFA9(this, SpecialStateTransition9);
	}

	private class DFA1 : DFA
	{
		private const string DFA1_eotS =
			"\x13\xFFFF\x1\x18\x5\xFFFF";
		private const string DFA1_eofS =
			"\x19\xFFFF";
		private const string DFA1_minS =
			"\x1\x61\x3\xFFFF\x1\x6C\x1\x6F\x1\x66\x3\xFFFF\x1\x68\x8\xFFFF\x1\x74"+
			"\x5\xFFFF";
		private const string DFA1_maxS =
			"\x1\x77\x3\xFFFF\x1\x6E\x1\x75\x1\x6E\x3\xFFFF\x1\x79\x8\xFFFF\x1\x74"+
			"\x5\xFFFF";
		private const string DFA1_acceptS =
			"\x1\xFFFF\x1\x1\x1\x2\x1\x3\x3\xFFFF\x1\xA\x1\xB\x1\xC\x1\xFFFF\x1\x10"+
			"\x1\x11\x1\x13\x1\x4\x1\x5\x1\x6\x1\x7\x1\x8\x1\xFFFF\x1\xD\x1\xE\x1"+
			"\xF\x1\x12\x1\x9";
		private const string DFA1_specialS =
			"\x19\xFFFF}>";
		private static readonly string[] DFA1_transitionS =
			{
				"\x1\x1\x1\x2\x1\xFFFF\x1\x3\x1\x4\x1\x5\x2\xFFFF\x1\x6\x2\xFFFF\x1\x7"+
				"\x1\xFFFF\x1\x8\x1\x9\x3\xFFFF\x1\xD\x1\xA\x1\xFFFF\x1\xB\x1\xC",
				"",
				"",
				"",
				"\x1\xE\x1\xFFFF\x1\xF",
				"\x1\x10\x5\xFFFF\x1\x11",
				"\x1\x12\x7\xFFFF\x1\x13",
				"",
				"",
				"",
				"\x1\x14\x6\xFFFF\x1\x15\x9\xFFFF\x1\x16",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x17",
				"",
				"",
				"",
				"",
				""
			};

		private static readonly short[] DFA1_eot = DFA.UnpackEncodedString(DFA1_eotS);
		private static readonly short[] DFA1_eof = DFA.UnpackEncodedString(DFA1_eofS);
		private static readonly char[] DFA1_min = DFA.UnpackEncodedStringToUnsignedChars(DFA1_minS);
		private static readonly char[] DFA1_max = DFA.UnpackEncodedStringToUnsignedChars(DFA1_maxS);
		private static readonly short[] DFA1_accept = DFA.UnpackEncodedString(DFA1_acceptS);
		private static readonly short[] DFA1_special = DFA.UnpackEncodedString(DFA1_specialS);
		private static readonly short[][] DFA1_transition;

		static DFA1()
		{
			int numStates = DFA1_transitionS.Length;
			DFA1_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA1_transition[i] = DFA.UnpackEncodedString(DFA1_transitionS[i]);
			}
		}

		public DFA1( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 1;
			this.eot = DFA1_eot;
			this.eof = DFA1_eof;
			this.min = DFA1_min;
			this.max = DFA1_max;
			this.accept = DFA1_accept;
			this.special = DFA1_special;
			this.transition = DFA1_transition;
		}

		public override string Description { get { return "12:1: ReservedWord : ( 'array' | 'break' | 'do' | 'else' | 'end' | 'for' | 'function' | 'if' | 'in' | 'let' | 'nil' | 'of' | 'then' | 'to' | 'type' | 'var' | 'while' | 'int' | 'string' );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA9 : DFA
	{
		private const string DFA9_eotS =
			"\x1\xFFFF\xD\x15\x2\xFFFF\x1\x13\x1\xFFFF\x1\x13\x1\xFFFF\x1\x15\x1\xFFFF"+
			"\x1\x15\x1\x2E\x4\x15\x2\x2E\x2\x15\x1\x2E\x1\x15\x1\x2E\x4\x15\x5\xFFFF"+
			"\x2\x15\x1\xFFFF\x1\x15\x2\x2E\x1\x15\x3\x2E\x2\x15\x1\x2E\x4\x15\x1"+
			"\x2E\x1\x15\x2\x2E\x2\x15\x2\x2E\x1\x15\x1\x2E\x2\x15\x1\x2E\x1\x15\x1"+
			"\x2E";
		private const string DFA9_eofS =
			"\x4C\xFFFF";
		private const string DFA9_minS =
			"\x1\x0\x2\x72\x1\x6F\x1\x6C\x1\x6F\x1\x66\x1\x65\x1\x69\x1\x66\x1\x68"+
			"\x1\x61\x1\x68\x1\x74\x2\xFFFF\x1\x0\x1\xFFFF\x1\x2A\x1\xFFFF\x1\x72"+
			"\x1\xFFFF\x1\x65\x1\x30\x1\x73\x1\x64\x1\x72\x1\x6E\x2\x30\x1\x74\x1"+
			"\x6C\x1\x30\x1\x65\x1\x30\x1\x70\x1\x72\x1\x69\x1\x72\x5\xFFFF\x2\x61"+
			"\x1\xFFFF\x1\x65\x2\x30\x1\x63\x3\x30\x1\x6E\x1\x65\x1\x30\x1\x6C\x1"+
			"\x69\x1\x79\x1\x6B\x1\x30\x1\x74\x2\x30\x1\x65\x1\x6E\x2\x30\x1\x69\x1"+
			"\x30\x1\x67\x1\x6F\x1\x30\x1\x6E\x1\x30";
		private const string DFA9_maxS =
			"\x1\xFFFF\x2\x72\x1\x6F\x1\x6E\x1\x75\x1\x6E\x1\x65\x1\x69\x1\x66\x1"+
			"\x79\x1\x61\x1\x68\x1\x74\x2\xFFFF\x1\xFFFF\x1\xFFFF\x1\x2F\x1\xFFFF"+
			"\x1\x72\x1\xFFFF\x1\x65\x1\x7A\x1\x73\x1\x64\x1\x72\x1\x6E\x2\x7A\x1"+
			"\x74\x1\x6C\x1\x7A\x1\x65\x1\x7A\x1\x70\x1\x72\x1\x69\x1\x72\x5\xFFFF"+
			"\x2\x61\x1\xFFFF\x1\x65\x2\x7A\x1\x63\x3\x7A\x1\x6E\x1\x65\x1\x7A\x1"+
			"\x6C\x1\x69\x1\x79\x1\x6B\x1\x7A\x1\x74\x2\x7A\x1\x65\x1\x6E\x2\x7A\x1"+
			"\x69\x1\x7A\x1\x67\x1\x6F\x1\x7A\x1\x6E\x1\x7A";
		private const string DFA9_acceptS =
			"\xE\xFFFF\x1\x2\x1\x3\x1\xFFFF\x1\x5\x1\xFFFF\x1\x8\x1\xFFFF\x1\x2\x11"+
			"\xFFFF\x1\x3\x1\x4\x1\x5\x1\x6\x1\x7\x2\xFFFF\x1\x1\x1D\xFFFF";
		private const string DFA9_specialS =
			"\x1\x0\xF\xFFFF\x1\x1\x3B\xFFFF}>";
		private static readonly string[] DFA9_transitionS =
			{
				"\x9\x13\x2\x11\x2\x13\x1\x11\x12\x13\x1\x11\x1\x13\x1\x10\xC\x13\x1"+
				"\x12\xA\xF\x7\x13\x1A\xE\x6\x13\x1\x1\x1\x2\x1\xE\x1\x3\x1\x4\x1\x5"+
				"\x2\xE\x1\x6\x2\xE\x1\x7\x1\xE\x1\x8\x1\x9\x3\xE\x1\xD\x1\xA\x1\xE\x1"+
				"\xB\x1\xC\x3\xE\xFF85\x13",
				"\x1\x14",
				"\x1\x16",
				"\x1\x17",
				"\x1\x18\x1\xFFFF\x1\x19",
				"\x1\x1A\x5\xFFFF\x1\x1B",
				"\x1\x1C\x7\xFFFF\x1\x1D",
				"\x1\x1E",
				"\x1\x1F",
				"\x1\x20",
				"\x1\x21\x6\xFFFF\x1\x22\x9\xFFFF\x1\x23",
				"\x1\x24",
				"\x1\x25",
				"\x1\x26",
				"",
				"",
				"\x0\x28",
				"",
				"\x1\x2A\x4\xFFFF\x1\x2B",
				"",
				"\x1\x2C",
				"",
				"\x1\x2D",
				"\xA\x15\x7\xFFFF\x1A\x15\x4\xFFFF\x1\x15\x1\xFFFF\x1A\x15",
				"\x1\x2F",
				"\x1\x30",
				"\x1\x31",
				"\x1\x32",
				"\xA\x15\x7\xFFFF\x1A\x15\x4\xFFFF\x1\x15\x1\xFFFF\x1A\x15",
				"\xA\x15\x7\xFFFF\x1A\x15\x4\xFFFF\x1\x15\x1\xFFFF\x13\x15\x1\x33\x6"+
				"\x15",
				"\x1\x34",
				"\x1\x35",
				"\xA\x15\x7\xFFFF\x1A\x15\x4\xFFFF\x1\x15\x1\xFFFF\x1A\x15",
				"\x1\x36",
				"\xA\x15\x7\xFFFF\x1A\x15\x4\xFFFF\x1\x15\x1\xFFFF\x1A\x15",
				"\x1\x37",
				"\x1\x38",
				"\x1\x39",
				"\x1\x3A",
				"",
				"",
				"",
				"",
				"",
				"\x1\x3B",
				"\x1\x3C",
				"",
				"\x1\x3D",
				"\xA\x15\x7\xFFFF\x1A\x15\x4\xFFFF\x1\x15\x1\xFFFF\x1A\x15",
				"\xA\x15\x7\xFFFF\x1A\x15\x4\xFFFF\x1\x15\x1\xFFFF\x1A\x15",
				"\x1\x3E",
				"\xA\x15\x7\xFFFF\x1A\x15\x4\xFFFF\x1\x15\x1\xFFFF\x1A\x15",
				"\xA\x15\x7\xFFFF\x1A\x15\x4\xFFFF\x1\x15\x1\xFFFF\x1A\x15",
				"\xA\x15\x7\xFFFF\x1A\x15\x4\xFFFF\x1\x15\x1\xFFFF\x1A\x15",
				"\x1\x3F",
				"\x1\x40",
				"\xA\x15\x7\xFFFF\x1A\x15\x4\xFFFF\x1\x15\x1\xFFFF\x1A\x15",
				"\x1\x41",
				"\x1\x42",
				"\x1\x43",
				"\x1\x44",
				"\xA\x15\x7\xFFFF\x1A\x15\x4\xFFFF\x1\x15\x1\xFFFF\x1A\x15",
				"\x1\x45",
				"\xA\x15\x7\xFFFF\x1A\x15\x4\xFFFF\x1\x15\x1\xFFFF\x1A\x15",
				"\xA\x15\x7\xFFFF\x1A\x15\x4\xFFFF\x1\x15\x1\xFFFF\x1A\x15",
				"\x1\x46",
				"\x1\x47",
				"\xA\x15\x7\xFFFF\x1A\x15\x4\xFFFF\x1\x15\x1\xFFFF\x1A\x15",
				"\xA\x15\x7\xFFFF\x1A\x15\x4\xFFFF\x1\x15\x1\xFFFF\x1A\x15",
				"\x1\x48",
				"\xA\x15\x7\xFFFF\x1A\x15\x4\xFFFF\x1\x15\x1\xFFFF\x1A\x15",
				"\x1\x49",
				"\x1\x4A",
				"\xA\x15\x7\xFFFF\x1A\x15\x4\xFFFF\x1\x15\x1\xFFFF\x1A\x15",
				"\x1\x4B",
				"\xA\x15\x7\xFFFF\x1A\x15\x4\xFFFF\x1\x15\x1\xFFFF\x1A\x15"
			};

		private static readonly short[] DFA9_eot = DFA.UnpackEncodedString(DFA9_eotS);
		private static readonly short[] DFA9_eof = DFA.UnpackEncodedString(DFA9_eofS);
		private static readonly char[] DFA9_min = DFA.UnpackEncodedStringToUnsignedChars(DFA9_minS);
		private static readonly char[] DFA9_max = DFA.UnpackEncodedStringToUnsignedChars(DFA9_maxS);
		private static readonly short[] DFA9_accept = DFA.UnpackEncodedString(DFA9_acceptS);
		private static readonly short[] DFA9_special = DFA.UnpackEncodedString(DFA9_specialS);
		private static readonly short[][] DFA9_transition;

		static DFA9()
		{
			int numStates = DFA9_transitionS.Length;
			DFA9_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA9_transition[i] = DFA.UnpackEncodedString(DFA9_transitionS[i]);
			}
		}

		public DFA9( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 9;
			this.eot = DFA9_eot;
			this.eof = DFA9_eof;
			this.min = DFA9_min;
			this.max = DFA9_max;
			this.accept = DFA9_accept;
			this.special = DFA9_special;
			this.transition = DFA9_transition;
		}

		public override string Description { get { return "1:1: Tokens : ( ReservedWord | Identifier | IntegerLiteral | StringLiteral | WhiteSpace | BlockComment | LineComment | Other );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition9(DFA dfa, int s, IIntStream _input)
	{
		IIntStream input = _input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA9_0 = input.LA(1);

				s = -1;
				if ((LA9_0=='a')) {s = 1;}

				else if ((LA9_0=='b')) {s = 2;}

				else if ((LA9_0=='d')) {s = 3;}

				else if ((LA9_0=='e')) {s = 4;}

				else if ((LA9_0=='f')) {s = 5;}

				else if ((LA9_0=='i')) {s = 6;}

				else if ((LA9_0=='l')) {s = 7;}

				else if ((LA9_0=='n')) {s = 8;}

				else if ((LA9_0=='o')) {s = 9;}

				else if ((LA9_0=='t')) {s = 10;}

				else if ((LA9_0=='v')) {s = 11;}

				else if ((LA9_0=='w')) {s = 12;}

				else if ((LA9_0=='s')) {s = 13;}

				else if (((LA9_0>='A' && LA9_0<='Z')||LA9_0=='c'||(LA9_0>='g' && LA9_0<='h')||(LA9_0>='j' && LA9_0<='k')||LA9_0=='m'||(LA9_0>='p' && LA9_0<='r')||LA9_0=='u'||(LA9_0>='x' && LA9_0<='z'))) {s = 14;}

				else if (((LA9_0>='0' && LA9_0<='9'))) {s = 15;}

				else if ((LA9_0=='\"')) {s = 16;}

				else if (((LA9_0>='\t' && LA9_0<='\n')||LA9_0=='\r'||LA9_0==' ')) {s = 17;}

				else if ((LA9_0=='/')) {s = 18;}

				else if (((LA9_0>='\u0000' && LA9_0<='\b')||(LA9_0>='\u000B' && LA9_0<='\f')||(LA9_0>='\u000E' && LA9_0<='\u001F')||LA9_0=='!'||(LA9_0>='#' && LA9_0<='.')||(LA9_0>=':' && LA9_0<='@')||(LA9_0>='[' && LA9_0<='`')||(LA9_0>='{' && LA9_0<='\uFFFF'))) {s = 19;}

				if (s >= 0) return s;
				break;
			case 1:
				int LA9_16 = input.LA(1);

				s = -1;
				if (((LA9_16>='\u0000' && LA9_16<='\uFFFF'))) {s = 40;}

				else s = 19;

				if (s >= 0) return s;
				break;
		}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 9, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}
 
	#endregion

}

} // namespace NaiveTiger

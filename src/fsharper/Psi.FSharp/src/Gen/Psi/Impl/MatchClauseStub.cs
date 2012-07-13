//------------------------------------------------------------------------------
// <auto-generated>
//     Generated by IntelliJ parserGen
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 0168, 0219, 0108, 0414
// ReSharper disable RedundantNameQualifier
using System;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.FSharp;
namespace JetBrains.ReSharper.Psi.FSharp.Impl.Tree {
  internal abstract partial class MatchClauseStub : JetBrains.ReSharper.Psi.FSharp.Impl.Tree.FSharpCompositeElement, JetBrains.ReSharper.Psi.FSharp.Tree.IMatchClauseNode, JetBrains.ReSharper.Psi.FSharp.Tree.IMatchClause {
    public const short PATTERN= JetBrains.ReSharper.Psi.FSharp.Impl.Tree.FSharpChildRole.LAST + 1;
    public const short WHEN_KEYWORD= JetBrains.ReSharper.Psi.FSharp.Impl.Tree.FSharpChildRole.LAST + 2;
    public const short CONDITION= JetBrains.ReSharper.Psi.FSharp.Impl.Tree.FSharpChildRole.LAST + 3;
    public const short FSHARP_RARROW= JetBrains.ReSharper.Psi.FSharp.Impl.Tree.FSharpChildRole.FSHARP_RARROW;
    public const short TARGET= JetBrains.ReSharper.Psi.FSharp.Impl.Tree.FSharpChildRole.LAST + 5;
    public MatchClauseStub() : base() {
    }
    public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType NodeType {
      get { return JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.MATCH_CLAUSE; }
    }
    public override void Accept(JetBrains.ReSharper.Psi.FSharp.ElementVisitor visitor) {
      visitor.VisitMatchClause(this);
    }
    public override TReturn Accept<TContext, TReturn>(JetBrains.ReSharper.Psi.FSharp.ElementVisitor<TContext,TReturn> visitor, TContext context) {
      return visitor.VisitMatchClause(this, context);
    }
    public override void Accept(JetBrains.ReSharper.Psi.FSharp.TreeNodeVisitor visitor) {
      visitor.VisitMatchClauseNode(this);
    }
    public override void Accept<TContext>(JetBrains.ReSharper.Psi.FSharp.TreeNodeVisitor<TContext> visitor, TContext context) {
      visitor.VisitMatchClauseNode(this, context);
    }
    public override TReturn Accept<TContext, TReturn>(JetBrains.ReSharper.Psi.FSharp.TreeNodeVisitor<TContext, TReturn> visitor, TContext context) {
      return visitor.VisitMatchClauseNode(this, context);
    }
    private static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeDictionary<short> CHILD_ROLES = new JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeDictionary<short>(
      new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>[]
      {
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.ARRAY_PATTERN, PATTERN),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.AS_VALUE_PATTERN, PATTERN),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.BRACKETED_PATTERN, PATTERN),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.CONSTANT_PATTERN, PATTERN),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.CONSTRUCTOR_REFERENCE, PATTERN),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.DISJUNCTION_PATTERN, PATTERN),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.LIST_CONSTRUCTOR_PATTERN, PATTERN),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.PARAMETERIZED_CONSTRUCTOR_PATTERN, PATTERN),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.PARENTHESIZED_PATTERN, PATTERN),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.RANGE_PATTERN, PATTERN),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.RECORD_PATTERN, PATTERN),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.TUPLE_PATTERN, PATTERN),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.TYPE_TEST_PATTERN, PATTERN),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.TYPED_PATTERN, PATTERN),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.UNDERLINE_PATTERN, PATTERN),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.VALUE_DECLARATION_PATTERN, PATTERN),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_WHEN, WHEN_KEYWORD),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_RARROW_OP, FSHARP_RARROW),
      }
    );
    public override short GetChildRole (JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) {
      short role = CHILD_ROLES[child.NodeType];
      if (role != 0) return role;
      JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement current = GetNextFilteredChild(null);
      if (current == null) return 0;
      if (child.parent != this) return 0;
      if (TokenBitsets.ElementBitset_1[current.NodeType]) {
        if (current == child) return PATTERN;
        current = GetNextFilteredChild(current);
        if (current == null) return 0;
      } else return 0;
      if (current.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_WHEN) {
        if (current.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_WHEN) {
          if (current == child) return WHEN_KEYWORD;
          current = GetNextFilteredChild(current);
          if (current == null) return 0;
        } else return 0;
        if (TokenBitsets.ElementBitset_0[current.NodeType]) {
          if (current == child) return CONDITION;
          current = GetNextFilteredChild(current);
          if (current == null) return 0;
        } else return 0;
      }
      if (current.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_RARROW_OP) {
        if (current == child) return FSHARP_RARROW;
        current = GetNextFilteredChild(current);
        if (current == null) return 0;
      } else return 0;
      if (TokenBitsets.ElementBitset_0[current.NodeType]) {
        if (current == child) return TARGET;
        current = GetNextFilteredChild(current);
        if (current == null) return 0;
      } else return 0;
      return 0;
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.IExpression Condition {
      get { return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpression) FindChildByRole(CONDITION); }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode ConditionNode {
      get { return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode) FindChildByRole(CONDITION); }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.IPattern Pattern {
      get { return (JetBrains.ReSharper.Psi.FSharp.Tree.IPattern) FindChildByRole(PATTERN); }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.IPatternNode PatternNode {
      get { return (JetBrains.ReSharper.Psi.FSharp.Tree.IPatternNode) FindChildByRole(PATTERN); }
    }
    public virtual JetBrains.ReSharper.Psi.ITokenNode RArrow {
      get { return (JetBrains.ReSharper.Psi.ITokenNode) FindChildByRole(FSHARP_RARROW); }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.IExpression Target {
      get { return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpression) FindChildByRole(TARGET); }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode TargetNode {
      get { return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode) FindChildByRole(TARGET); }
    }
    public virtual JetBrains.ReSharper.Psi.ITokenNode WhenKeyword {
      get { return (JetBrains.ReSharper.Psi.ITokenNode) FindChildByRole(WHEN_KEYWORD); }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.IExpression SetCondition (JetBrains.ReSharper.Psi.FSharp.Tree.IExpression param)
    {
      using (JetBrains.Application.WriteLockCookie.Create (this.IsPhysical()))
      {
        TreeElement current = null, next = GetNextFilteredChild (current), result = null;
        next = GetNextFilteredChild (current);
        if (next == null) {
          return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpression)result;
        } else {
          if (TokenBitsets.ElementBitset_1[next.NodeType]) {
            current = next;
          } else {
            return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpression)result;
          }
        }
        next = GetNextFilteredChild (current);
        if (next == null) {
          result = current = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildAfter (this, current, TreeElementFactory.CreateErrorElement (string.Empty));
        } else {
          if (next.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_WHEN) {
            if (param != null) {
              current = next;
            } else {
              current = GetNextFilteredChild (next);
              JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.DeleteChild (next);
            }
          } else {
            return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpression)result;
          }
        }
        next = GetNextFilteredChild (current);
        if (next == null) {
          if (param == null) return null;
          result = current = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildAfter (this, current, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
        } else {
          if (TokenBitsets.ElementBitset_0[next.NodeType]) {
            if (param != null) {
              result = current = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.ReplaceChild(next, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
            } else {
              current = GetNextFilteredChild (next);
              JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.DeleteChild (next);
            }
          } else {
            if (param == null) return null;
            result = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildBefore(next, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
            current = next;
          }
        }
        return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpression)result;
      }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode SetConditionNode (JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode param)
    {
      using (JetBrains.Application.WriteLockCookie.Create (this.IsPhysical()))
      {
        TreeElement current = null, next = GetNextFilteredChild (current), result = null;
        next = GetNextFilteredChild (current);
        if (next == null) {
          return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode)result;
        } else {
          if (TokenBitsets.ElementBitset_1[next.NodeType]) {
            current = next;
          } else {
            return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode)result;
          }
        }
        next = GetNextFilteredChild (current);
        if (next == null) {
          result = current = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildAfter (this, current, TreeElementFactory.CreateErrorElement (string.Empty));
        } else {
          if (next.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_WHEN) {
            if (param != null) {
              current = next;
            } else {
              current = GetNextFilteredChild (next);
              JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.DeleteChild (next);
            }
          } else {
            return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode)result;
          }
        }
        next = GetNextFilteredChild (current);
        if (next == null) {
          if (param == null) return null;
          result = current = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildAfter (this, current, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
        } else {
          if (TokenBitsets.ElementBitset_0[next.NodeType]) {
            if (param != null) {
              result = current = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.ReplaceChild(next, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
            } else {
              current = GetNextFilteredChild (next);
              JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.DeleteChild (next);
            }
          } else {
            if (param == null) return null;
            result = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildBefore(next, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
            current = next;
          }
        }
        return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode)result;
      }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.IPattern SetPattern (JetBrains.ReSharper.Psi.FSharp.Tree.IPattern param)
    {
      using (JetBrains.Application.WriteLockCookie.Create (this.IsPhysical()))
      {
        TreeElement current = null, next = GetNextFilteredChild (current), result = null;
        next = GetNextFilteredChild (current);
        if (next == null) {
          if (param == null) return null;
          result = current = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildAfter (this, current, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
        } else {
          if (TokenBitsets.ElementBitset_1[next.NodeType]) {
            if (param != null) {
              result = current = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.ReplaceChild(next, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
            } else {
              current = GetNextFilteredChild (next);
              JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.DeleteChild (next);
            }
          } else {
            if (param == null) return null;
            result = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildBefore(next, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
            current = next;
          }
        }
        return (JetBrains.ReSharper.Psi.FSharp.Tree.IPattern)result;
      }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.IPatternNode SetPatternNode (JetBrains.ReSharper.Psi.FSharp.Tree.IPatternNode param)
    {
      using (JetBrains.Application.WriteLockCookie.Create (this.IsPhysical()))
      {
        TreeElement current = null, next = GetNextFilteredChild (current), result = null;
        next = GetNextFilteredChild (current);
        if (next == null) {
          if (param == null) return null;
          result = current = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildAfter (this, current, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
        } else {
          if (TokenBitsets.ElementBitset_1[next.NodeType]) {
            if (param != null) {
              result = current = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.ReplaceChild(next, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
            } else {
              current = GetNextFilteredChild (next);
              JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.DeleteChild (next);
            }
          } else {
            if (param == null) return null;
            result = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildBefore(next, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
            current = next;
          }
        }
        return (JetBrains.ReSharper.Psi.FSharp.Tree.IPatternNode)result;
      }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.IExpression SetTarget (JetBrains.ReSharper.Psi.FSharp.Tree.IExpression param)
    {
      using (JetBrains.Application.WriteLockCookie.Create (this.IsPhysical()))
      {
        TreeElement current = null, next = GetNextFilteredChild (current), result = null;
        next = GetNextFilteredChild (current);
        if (next == null) {
          return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpression)result;
        } else {
          if (TokenBitsets.ElementBitset_1[next.NodeType]) {
            current = next;
          } else {
            return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpression)result;
          }
        }
        next = GetNextFilteredChild (current);
        if (next != null && (next.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_WHEN)) {
          next = GetNextFilteredChild (current);
          if (next == null) {
            return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpression)result;
          } else {
            if (next.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_WHEN) {
              current = next;
            } else {
              return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpression)result;
            }
          }
          next = GetNextFilteredChild (current);
          if (next == null) {
            return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpression)result;
          } else {
            if (TokenBitsets.ElementBitset_0[next.NodeType]) {
              current = next;
            } else {
              return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpression)result;
            }
          }
        }  
        next = GetNextFilteredChild (current);
        if (next == null) {
          return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpression)result;
        } else {
          if (next.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_RARROW_OP) {
            current = next;
          } else {
            return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpression)result;
          }
        }
        next = GetNextFilteredChild (current);
        if (next == null) {
          if (param == null) return null;
          result = current = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildAfter (this, current, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
        } else {
          if (TokenBitsets.ElementBitset_0[next.NodeType]) {
            if (param != null) {
              result = current = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.ReplaceChild(next, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
            } else {
              current = GetNextFilteredChild (next);
              JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.DeleteChild (next);
            }
          } else {
            if (param == null) return null;
            result = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildBefore(next, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
            current = next;
          }
        }
        return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpression)result;
      }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode SetTargetNode (JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode param)
    {
      using (JetBrains.Application.WriteLockCookie.Create (this.IsPhysical()))
      {
        TreeElement current = null, next = GetNextFilteredChild (current), result = null;
        next = GetNextFilteredChild (current);
        if (next == null) {
          return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode)result;
        } else {
          if (TokenBitsets.ElementBitset_1[next.NodeType]) {
            current = next;
          } else {
            return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode)result;
          }
        }
        next = GetNextFilteredChild (current);
        if (next != null && (next.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_WHEN)) {
          next = GetNextFilteredChild (current);
          if (next == null) {
            return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode)result;
          } else {
            if (next.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_WHEN) {
              current = next;
            } else {
              return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode)result;
            }
          }
          next = GetNextFilteredChild (current);
          if (next == null) {
            return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode)result;
          } else {
            if (TokenBitsets.ElementBitset_0[next.NodeType]) {
              current = next;
            } else {
              return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode)result;
            }
          }
        }  
        next = GetNextFilteredChild (current);
        if (next == null) {
          return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode)result;
        } else {
          if (next.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_RARROW_OP) {
            current = next;
          } else {
            return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode)result;
          }
        }
        next = GetNextFilteredChild (current);
        if (next == null) {
          if (param == null) return null;
          result = current = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildAfter (this, current, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
        } else {
          if (TokenBitsets.ElementBitset_0[next.NodeType]) {
            if (param != null) {
              result = current = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.ReplaceChild(next, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
            } else {
              current = GetNextFilteredChild (next);
              JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.DeleteChild (next);
            }
          } else {
            if (param == null) return null;
            result = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildBefore(next, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
            current = next;
          }
        }
        return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode)result;
      }
    }
    JetBrains.ReSharper.Psi.FSharp.Tree.IMatchClauseNode JetBrains.ReSharper.Psi.FSharp.Tree.IMatchClause.ToTreeNode() { return this; }
    public override string ToString() {
      return "IMatchClause";
    }
  }
}
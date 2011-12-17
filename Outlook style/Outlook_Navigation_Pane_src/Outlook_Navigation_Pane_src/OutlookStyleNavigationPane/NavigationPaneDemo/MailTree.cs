/*
 * Proje	: 
 *
 * Hazırlayan   : Muhammed ŞAHİN
 * eMail        : muhammed.sahin@gmail.com
 *
 * Açıklama	:	
 *	
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace NavigationPaneDemo
{
    public partial class MailTree : UserControl
    {

        TreeNode mailBox;
        TreeNode nodeInbox;
        TreeNode nodeSendBox;

        public MailTree()
        {
            InitializeComponent();
            treeMailBox.BorderStyle = BorderStyle.None;

            mailBox = new TreeNode("MailBox");

            nodeInbox = new TreeNode("Inbox");
            nodeSendBox = new TreeNode("Sendbox");

            mailBox.Nodes.Add(nodeInbox);
            mailBox.Nodes.Add(nodeSendBox);

            this.treeMailBox.Nodes.Add(mailBox);
            this.treeMailBox.ExpandAll();
        }

    }
}

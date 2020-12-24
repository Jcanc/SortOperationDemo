using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private List<Student> lstStu = new List<Student>();
        private void Form1_Load(object sender, EventArgs e) {
            var nowYear = DateTime.Now.Year;
            lstStu = new List<Student> {
                new Student {
                    Id = 1,
                    Name = "小明",
                    Age = 12,
                    Sex = "男",
                    Address = "东莞南城",
                    Seq = 1
                },
                new Student {
                    Id = 2,
                    Name = "小红",
                    Age = 11,
                    Sex = "女",
                    Address = "东莞东城",
                    Seq = 2
                },
                new Student {
                    Id = 3,
                    Name = "小军",
                    Age = 13,
                    Sex = "男",
                    Address = "东莞莞城",
                    Seq = 3
                },
                new Student {
                    Id = 4,
                    Name = "小芳",
                    Age = 12,
                    Sex = "女",
                    Address = "东莞厚街",
                    Seq = 4
                },
                new Student {
                    Id = 5,
                    Name = "小李",
                    Age = 14,
                    Sex = "男",
                    Address = "东莞大朗",
                    Seq = 5
                }
            };

            lstStu = lstStu.OrderBy(o => o.Seq).ToList();
            gridControl1.DataSource = lstStu;
            gridView1.FocusedRowHandle = 0;
        }

        private void bbiTopping_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            try {

                if (gridView1.FocusedRowHandle >= 0) {
                    var m = gridView1.GetRow(gridView1.FocusedRowHandle) as Student;
                    var list = gridControl1.DataSource as List<Student>;
                    
                    var minSeq = list.Min(o => o.Seq);
                    if (m.Seq > 1) {
                        var focusedSeq = m.Seq;
                        foreach (var stu in list) {
                            if (stu.Seq < focusedSeq) {
                                stu.Seq += 1;
                            }else if (stu.Seq == focusedSeq) {
                                stu.Seq = minSeq;
                            }
                        }

                        //var firstHalf = list.FindAll(o => o.Seq < m.Seq);
                        //var secondHalf = list.FindAll(o => o.Seq > m.Seq) as IEnumerable<Student>;

                        //for (int i = 0; i < firstHalf.Count; i++) {
                        //    firstHalf[i].Seq = firstHalf[i].Seq + 1;
                        //}

                        //m.Seq = minSeq;
                        //firstHalf.Add(m);
                        //firstHalf.AddRange(secondHalf);
                        //list = firstHalf.OrderBy(o => o.Seq).ToList();
                        list = list.OrderBy(o => o.Seq).ToList();

                        gridControl1.DataSource = list;
                        gridView1.FocusedRowHandle = 0;
                    }

                }

            } catch (Exception ex) {
                XtraMessageBox.Show(ex.ToString());
            }
        }

        private void bbiMoveUp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            try {

                if (gridView1.FocusedRowHandle >= 0) {
                    var m = gridView1.GetRow(gridView1.FocusedRowHandle) as Student;
                    var list = gridControl1.DataSource as List<Student>;
                    
                    if (m.Seq > 1) {
                        var focusedSeq = m.Seq;
                        foreach (var stu in list) {
                            if (stu.Seq == focusedSeq) {
                                stu.Seq = focusedSeq - 1;
                            }else if (stu.Seq == focusedSeq - 1) {
                                stu.Seq = focusedSeq;
                            }
                        }

                        list = list.OrderBy(o => o.Seq).ToList();

                        gridControl1.DataSource = list;
                        gridView1.FocusedRowHandle = focusedSeq - 2;
                    }

                }

            } catch (Exception ex) {
                XtraMessageBox.Show(ex.ToString());
            }
        }

        private void bbiMoveDown_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            try {

                if (gridView1.FocusedRowHandle >= 0) {
                    var m = gridView1.GetRow(gridView1.FocusedRowHandle) as Student;
                    var list = gridControl1.DataSource as List<Student>;

                    if (m.Seq < list.Count) {
                        var focusedSeq = m.Seq;
                        foreach (var stu in list) {
                            if (stu.Seq == focusedSeq) {
                                stu.Seq = focusedSeq + 1;
                            } else if (stu.Seq == focusedSeq + 1) {
                                stu.Seq = focusedSeq;
                            }
                        }

                        list = list.OrderBy(o => o.Seq).ToList();

                        gridControl1.DataSource = list;
                        gridView1.FocusedRowHandle = focusedSeq;
                    }

                }

            } catch (Exception ex) {
                XtraMessageBox.Show(ex.ToString());
            }
        }

        private void bbiSetTheButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            try {

                if (gridView1.FocusedRowHandle >= 0) {
                    var m = gridView1.GetRow(gridView1.FocusedRowHandle) as Student;
                    var list = gridControl1.DataSource as List<Student>;

                    var maxSeq = list.Max(o => o.Seq);
                    if (m.Seq < list.Count) {
                        var focusedSeq = m.Seq;
                        foreach (var stu in list) {
                            if (stu.Seq > focusedSeq) {
                                stu.Seq -= 1;
                            }else if (stu.Seq == focusedSeq) {
                                stu.Seq = maxSeq;
                            }
                        }
                        //var firstHalf = list.FindAll(o => o.Seq < m.Seq) as IEnumerable<Student>;
                        //var secondHalf = list.FindAll(o => o.Seq > m.Seq);

                        //for (int i = 0; i < secondHalf.Count; i++) {
                        //    secondHalf[i].Seq = secondHalf[i].Seq - 1;
                        //}

                        //m.Seq = maxSeq;
                        //secondHalf.Add(m);
                        //secondHalf.AddRange(firstHalf);
                        //list = secondHalf.OrderBy(o => o.Seq).ToList();
                        list = list.OrderBy(o => o.Seq).ToList();

                        gridControl1.DataSource = list;
                        gridView1.FocusedRowHandle = list.Count - 1;
                    }

                }

            } catch (Exception ex) {
                XtraMessageBox.Show(ex.ToString());
            }
        }


    }
}

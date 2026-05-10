import pandas as pd
import numpy as np

# Tạo DataFrame chứa thông tin 10 sinh viên (ít nhất 2 sinh viên thiếu điểm - NaN)
data = {
    'MSSV': ['SV01', 'SV02', 'SV03', 'SV04', 'SV05', 'SV06', 'SV07', 'SV08', 'SV09', 'SV10'],
    'Họ tên': ['Nguyễn Văn A', 'Trần Thị B', 'Lê Văn C', 'Phạm Thị D', 'Hoàng Văn E', 
               'Vũ Thị F', 'Đặng Văn G', 'Bùi Thị H', 'Đỗ Văn I', 'Hồ Thị J'],
    'Ngành': ['IT', 'Kinh tế', 'IT', 'Ngoại ngữ', 'Kinh tế', 
              'IT', 'Ngoại ngữ', 'IT', 'Kinh tế', 'Ngoại ngữ'],
    'Điểm TB': [8.5, 7.0, np.nan, 9.2, 6.5, 8.8, np.nan, 5.5, 9.5, 7.8],
    'Số tín chỉ đã học': [120, 100, 110, 90, 105, 115, 85, 125, 100, 95]
}
df = pd.DataFrame(data)

#In ra 5 sinh viên có điểm TB cao nhất
print("--- 5 sinh viên có điểm TB cao nhất ---")
top_5_sv = df.nlargest(5, 'Điểm TB')
print(top_5_sv)

#Lọc danh sách sinh viên có điểm TB >= 8.0
print("\n--- Danh sách sinh viên có điểm TB >= 8.0 ---")
sv_gioi = df[df['Điểm TB'] >= 8.0]
print(sv_gioi)

# Tính điểm TB trung bình theo từng ngành
print("\n--- Điểm TB trung bình theo ngành ---")
tb_theo_nganh = df.groupby('Ngành')['Điểm TB'].mean()
print(tb_theo_nganh)

#Xử lý dữ liệu bị thiếu: thay thế
df['Điểm TB'] = df.groupby('Ngành')['Điểm TB'].transform(lambda x: x.fillna(x.mean()))
print("\n--- DataFrame sau khi xử lý điểm bị thiếu ---")
print(df)

#Ghi kết quả ra 
with pd.ExcelWriter('KetQua_SinhVien.xlsx') as writer:
    df.to_excel(writer, sheet_name='Tat_ca', index=False)
    sv_gioi.to_excel(writer, sheet_name='Gioi', index=False)
    tb_theo_nganh.reset_index().to_excel(writer, sheet_name='Thong_ke', index=False)
print("\nĐã lưu kết quả ra file 'KetQua_SinhVien.xlsx'.")

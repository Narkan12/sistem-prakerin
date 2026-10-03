import re

def resolve_conflicts_keep_theirs(text):
    """Remove HEAD..======= blocks, keep theirs side, strip >>>>>>> markers."""
    pattern = r'<<<<<<< HEAD.*?=======\n(.*?)>>>>>>> [^\n]*\n'
    result = re.sub(pattern, r'\1', text, flags=re.DOTALL)
    return result

files = [
    r'e:\all\DesktopC#-12\Progress_V2\sistem-prakerin-master\Form\FormCRUDPenilaian.Designer.cs',
    r'e:\all\DesktopC#-12\Progress_V2\sistem-prakerin-master\Form\FormCRUDPengguna.Designer.cs',
]

for path in files:
    with open(path, 'r', encoding='utf-8') as f:
        original = f.read()
    resolved = resolve_conflicts_keep_theirs(original)
    remaining = resolved.count('<<<<<<<') + resolved.count('>>>>>>>') 
    with open(path, 'w', encoding='utf-8') as f:
        f.write(resolved)
    print(f"DONE: {path} | markers_remaining={remaining}")

import re, sys

def resolve_conflict(path):
    with open(path, 'r', encoding='utf-8-sig') as f:
        content = f.read()

    # Check if there are any conflict markers
    if '<<<<<<<' not in content:
        return False, "no conflicts found"

    lines = content.split('\n')
    result = []
    in_head = False
    in_theirs = False
    changed = False

    for line in lines:
        if line.startswith('<<<<<<< '):
            in_head = True
            in_theirs = False
            changed = True
            continue
        elif line.startswith('=======') and in_head:
            in_head = False
            in_theirs = True
            continue
        elif line.startswith('>>>>>>> ') and in_theirs:
            in_theirs = False
            continue

        if in_head:
            # discard HEAD side
            continue
        else:
            result.append(line)

    resolved = '\n'.join(result)
    # Write back with UTF-8 BOM to match original (Designer files typically have BOM)
    with open(path, 'w', encoding='utf-8-sig') as f:
        f.write(resolved)

    return changed, "resolved"

files = [
    r"e:\all\DesktopC#-12\Progress_V2\sistem-prakerin-master\app_prakerin\Form\FormCRUDMonitoring.cs",
    r"e:\all\DesktopC#-12\Progress_V2\sistem-prakerin-master\app_prakerin\Form\FormCRUDMonitoring.Designer.cs",
    r"e:\all\DesktopC#-12\Progress_V2\sistem-prakerin-master\app_prakerin\Form\FMonitoring.cs",
    r"e:\all\DesktopC#-12\Progress_V2\sistem-prakerin-master\app_prakerin\Form\FMonitoring.Designer.cs",
]

for f in files:
    changed, msg = resolve_conflict(f)
    print(f"{f}: {msg}")

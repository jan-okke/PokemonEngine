using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Cryogonal : Pokemon
{
	public override string Name => "Cryogonal";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Levitate() };
	public override Stats BaseStats => new Stats(80, 50, 50, 95, 135, 105);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Ice };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Bind(), new Moves.Iceshard() },
		[4] = new List<Move>() { new Moves.Confuseray() },
		[8] = new List<Move>() { new Moves.Rapidspin() },
		[12] = new List<Move>() { new Moves.Laserfocus() },
		[16] = new List<Move>() { new Moves.Icywind() },
		[20] = new List<Move>() { new Moves.Mist(), new Moves.Haze() },
		[24] = new List<Move>() { new Moves.Ancientpower() },
		[28] = new List<Move>() { new Moves.Aurorabeam() },
		[32] = new List<Move>() { new Moves.Slash(), new Moves.Nightslash() },
		[36] = new List<Move>() { new Moves.Freezedry() },
		[40] = new List<Move>() { new Moves.Lightscreen(), new Moves.Reflect() },
		[44] = new List<Move>() { new Moves.Recover() },
		[48] = new List<Move>() { new Moves.Icebeam() },
		[52] = new List<Move>() { new Moves.Acidarmor() },
		[56] = new List<Move>() { new Moves.Solarbeam() },
		[60] = new List<Move>() { new Moves.Sheercold() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Endure(), new Moves.Facade(), new Moves.Flashcannon(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Iciclespear(), new Moves.Icywind(), new Moves.Irondefense(), new Moves.Lightscreen(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Round(), new Moves.Selfdestruct(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Tripleaxel() };
	public override int Weight => 1480;
	public override int ExpYield => 180;
	public override int CatchRate => 25;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 2,
		[Stat.Speed] = 0
	};
}
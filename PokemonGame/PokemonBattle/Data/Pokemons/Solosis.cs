using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Solosis : Pokemon
{
	public override string Name => "Solosis";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Overcoat(), new Abilities.Magicguard() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Regenerator() };
	public override Stats BaseStats => new Stats(45, 30, 40, 105, 50, 20);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Psychic };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Protect(), new Moves.Confusion() },
		[4] = new List<Move>() { new Moves.Recover() },
		[8] = new List<Move>() { new Moves.Endeavor() },
		[12] = new List<Move>() { new Moves.Psybeam() },
		[16] = new List<Move>() { new Moves.Charm() },
		[20] = new List<Move>() { new Moves.Psyshock() },
		[24] = new List<Move>() { new Moves.Lightscreen(), new Moves.Reflect() },
		[28] = new List<Move>() { new Moves.Allyswitch() },
		[33] = new List<Move>() { new Moves.Painsplit() },
		[36] = new List<Move>() { new Moves.Psychic() },
		[40] = new List<Move>() { new Moves.Skillswap() },
		[44] = new List<Move>() { new Moves.Futuresight() },
		[48] = new List<Move>() { new Moves.Wonderroom() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Attract(), new Moves.Calmmind(), new Moves.Charm(), new Moves.Encore(), new Moves.Endure(), new Moves.Energyball(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Flashcannon(), new Moves.Futuresight(), new Moves.Guardswap(), new Moves.Gyroball(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Imprison(), new Moves.Irondefense(), new Moves.Lightscreen(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychicterrain(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shadowball(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelroller(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Thunder(), new Moves.Thunderwave(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Wonderroom(), new Moves.Zenheadbutt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Acidarmor(), new Moves.Astonish(), new Moves.Confuseray() };
	public override int Weight => 10;
	public override int ExpYield => 58;
	public override int CatchRate => 200;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 1,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}